using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;

namespace Members
{
    public partial class Qry7Frm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Functions   -
        public Qry7Frm()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            DataTable dt = SQLProvider.SelectQry7();
            gridControlData.DataSource = dt;
        }
        #endregion
        #region -   Event Handlers   -
        private void QryTblAhteatyFrm_Load(object sender, EventArgs e)
        {
            LoadData();
            btnPrintExport.Visible = Program.UserInfo.IsAdmin;
        }
        private void btnPrintExport_Click(object sender, EventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!gridControlData.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }

            // Open the Preview window.
            gridControlData.ShowRibbonPrintPreview();
        }
        private void gridViewData_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            GridGroupRowInfo info = e.Info as GridGroupRowInfo;
            if (info == null) return;
            if (info.Column.FieldName == "UserName")
            {
                object UserName = gridViewData.GetGroupRowValue(info.RowHandle);
                object sumtext = gridViewData.GetGroupSummaryValue(info.RowHandle, (GridGroupSummaryItem)gridViewData.GroupSummary[0]);

                info.GroupText = string.Format("{0}  -  {1}", UserName, sumtext);
            }

        }
        #endregion

    }
}