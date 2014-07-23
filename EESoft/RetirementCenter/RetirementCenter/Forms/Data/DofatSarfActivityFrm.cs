using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace RetirementCenter.Forms.Data
{
    public partial class DofatSarfActivityFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();

        public DofatSarfActivityFrm()
        {
            InitializeComponent();

            LSMSCDSyndicate.QueryableSource = dsLinq.CDSyndicates;
            LSMSTBLDofatSarf.QueryableSource = dsLinq.TBLDofatSarfs;
            LSMSCDMashHala.QueryableSource = dsLinq.CDMashHalas;
            LoadData();
        }
        private void LoadData()
        {
            dofatSarfActivityTableAdapter.Fill(dsRetirementCenter.DofatSarfActivity);
        }
        private void DofatSarfActivityFrm_Load(object sender, EventArgs e)
        {
        }
        private void repositoryItemButtonEditTransferSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataSources.dsRetirementCenter.DofatSarfActivityRow row =
                (DataSources.dsRetirementCenter.DofatSarfActivityRow)((DataRowView)gridViewData.GetRow(gridViewData.FocusedRowHandle)).Row;
            try
            {
                row.datein = SQLProvider.ServerDateTime();
                row.userin = Program.UserInfo.UserId;

                dofatSarfActivityBindingSource.EndEdit();
                dofatSarfActivityTableAdapter.Update(row);
                Program.ShowMsg("تم التعديل", false, this, true);
                Program.Logger.LogThis("تم التعديل", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }

    }
}