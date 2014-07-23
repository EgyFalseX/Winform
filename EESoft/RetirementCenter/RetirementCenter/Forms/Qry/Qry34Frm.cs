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
    public partial class Qry34Frm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Functions   -
        public Qry34Frm()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -
        private void Qry06Frm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsQueries.CDSyndicate' table. You can move, or remove it, as needed.
            this.cDSyndicateTableAdapter.Fill(this.dsQueries.CDSyndicate);
            // TODO: This line of code loads data into the 'dsQueries.TBLDofatSarf' table. You can move, or remove it, as needed.
            this.tBLDofatSarfTableAdapter.Fill(this.dsQueries.TBLDofatSarf);
            
        }
        private void tbnSearch_Click(object sender, EventArgs e)
        {
            if (lueDofatSarfId.EditValue == null || lueSyndicateId.EditValue == null)
            {
                msgDlg.Show("يجب اختيار دفعة و لجنة");
                return;
            }
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                vQry34TableAdapter.Fill(dsQueries.vQry34, Convert.ToInt32(lueDofatSarfId.EditValue), Convert.ToInt32(lueSyndicateId.EditValue));
                gridViewData.BestFitColumns();
            }));
            SplashScreenManager.CloseForm();
        }
        private void btnPrintExport_Click(object sender, EventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!gridControlData.IsPrintingAvailable)
            {
                msgDlg.Show("The 'DevExpress.XtraPrinting' library is not found");
                return;
            }

            // Open the Preview window.
            gridControlData.ShowRibbonPrintPreview();
        }

        #endregion

        

    }
}
