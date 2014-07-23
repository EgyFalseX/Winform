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
    public partial class Qry001Frm : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(Qry001Frm));
        DataSources.Linq.dsLinqDataContext dsLinq = new DataSources.Linq.dsLinqDataContext();
        #region -   Functions   -
        public Qry001Frm()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -
        private void Qry06Frm_Load(object sender, EventArgs e)
        {
            LSMS.QueryableSource = dsLinq.vQry001s;

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
