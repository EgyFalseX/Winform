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
using log4net;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace NestleICSales
{
    public partial class Qry002Frm : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(Qry002Frm));
        DataSources.Linq.dsLinqDataContext dsLinq = new DataSources.Linq.dsLinqDataContext();
        #region -   Functions   -
        public Qry002Frm()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -
        private void QryFrm_Load(object sender, EventArgs e)
        {
            LSMS.QueryableSource = dsLinq.vQry002s;

            gridViewData.BestFitColumns();
        }
        private void btnPrintExport_Click(object sender, EventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!gridControlData.IsPrintingAvailable)
            {
                Logger.Error("The 'DevExpress.XtraPrinting' library is not found");
                return;
            }

            // Open the Preview window.
            gridControlData.ShowRibbonPrintPreview();
        }
        
        #endregion

        

    }
}
