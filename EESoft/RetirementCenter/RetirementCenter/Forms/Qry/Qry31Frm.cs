using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace RetirementCenter
{
    public partial class Qry31Frm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        #region -   Functions   -
        public Qry31Frm()
        {
            InitializeComponent();
            //XPSCSData.Session.ConnectionString = Properties.Settings.Default.RetirementCenterConnectionString;
        }
        #endregion
        #region -   Event Handlers   -
        private void Qry06Frm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsQueries.vQry31' table. You can move, or remove it, as needed.
            //this.vQry31TableAdapter.Fill(this.dsQueries.vQry31);
            
            //LSMS.QueryableSource = dsLinq.vQry31s;
            
            //pivotGridControlMain.BestFitColumns();
        }
        private void btnPrintExport_Click(object sender, EventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!pivotGridControlMain.IsPrintingAvailable)
            {
                msgDlg.Show("The 'DevExpress.XtraPrinting' library is not found");
                return;
            }
            // Open the Preview window.
            pivotGridControlMain.ShowRibbonPrintPreview();
        }

        #endregion

        private void Qry31Frm_Shown(object sender, EventArgs e)
        {
            pivotGridControlMain.UseWaitCursor = true;
            pivotGridControlMain.SetDataSourceAsync(this.vQry31TableAdapter.GetData());
            pivotGridControlMain.UseWaitCursor = false;
        }

    }
}
