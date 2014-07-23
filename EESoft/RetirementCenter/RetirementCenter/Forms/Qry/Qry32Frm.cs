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
    public partial class Qry32Frm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        #region -   Functions   -
        public Qry32Frm()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -
        private void Frm_Load(object sender, EventArgs e)
        {
            
        }
        private void Frm_Shown(object sender, EventArgs e)
        {
            pivotGridControlMain.UseWaitCursor = true;
            pivotGridControlMain.SetDataSourceAsync(this.vQry32TableAdapter.GetData());
            pivotGridControlMain.UseWaitCursor = false;
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

        

    }
}
