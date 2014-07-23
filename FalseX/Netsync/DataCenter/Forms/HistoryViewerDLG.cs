using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace DataCenter.Forms
{
    public partial class HistoryViewerDLG : DevExpress.XtraEditors.XtraForm
    {
        
        DataSources.Linq.dsDataCenterLinqDataContext LinqDS = new DataSources.Linq.dsDataCenterLinqDataContext();
        nsLib.Utilities.Types.LogType _logType;
        int _Index = 0;

        public HistoryViewerDLG(nsLib.Utilities.Types.LogType logtype, int index)
        {
            InitializeComponent();
            _logType = logtype;
            _Index = index;
        }
        private void LoadData()
        {
            // TODO: This line of code loads data into the 'dsQueries.QryLogs' table. You can move, or remove it, as needed.
            this.qryLogsTableAdapter.FillByLogTypeId_LogIndex(this.dsQueries.QryLogs, (int)_logType, _Index);
        }
        private void HistoryViewerDLG_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void gridViewHistoryCategory_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName != "LogIndexExtra" || e.RowHandle < 0 || e.CellValue == null)
                return;
            
            DataSources.dsDataCenter.LogsRow row = (DataSources.dsDataCenter.LogsRow)gridViewHistoryCategory.GetDataRow(e.RowHandle);
            switch (row.LogOpId)
            {
                case (int)nsLib.Utilities.Types.LogOpType.Inset:
                case (int)nsLib.Utilities.Types.LogOpType.Update:
                case (int)nsLib.Utilities.Types.LogOpType.Delete:
                    colLogNameExtra.ColumnEdit = null;
                    break;
                case (int)nsLib.Utilities.Types.LogOpType.AddAllowedRole:
                case (int)nsLib.Utilities.Types.LogOpType.AddDeniedRole:
                case (int)nsLib.Utilities.Types.LogOpType.DeleteAllowedRole:
                case (int)nsLib.Utilities.Types.LogOpType.DeleteDeniedRole:
                case (int)nsLib.Utilities.Types.LogOpType.EditAllowedRole:
                case (int)nsLib.Utilities.Types.LogOpType.EditDeniedRole:
                    colLogNameExtra.ColumnEdit = repositoryItemLookUpEditRole;
                    break;
                case (int)nsLib.Utilities.Types.LogOpType.AddAllowedUser:
                case (int)nsLib.Utilities.Types.LogOpType.AddDeniedUser:
                case (int)nsLib.Utilities.Types.LogOpType.DeleteAllowedUser:
                case (int)nsLib.Utilities.Types.LogOpType.DeleteDeniedUser:
                case (int)nsLib.Utilities.Types.LogOpType.EditAllowedUser:
                case (int)nsLib.Utilities.Types.LogOpType.EditDeniedUser:
                    colLogNameExtra.ColumnEdit = repositoryItemLookUpEditUserId;
                    break;
            }
        }
        private void gridViewHistoryCategory_CustomRowCellEditForEditing(object sender, CustomRowCellEditEventArgs e)
        {

        }
       
    }
}