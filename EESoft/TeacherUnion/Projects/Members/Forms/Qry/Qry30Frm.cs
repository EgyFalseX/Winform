using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;
using System.Linq;

namespace Members.Forms.Qry
{
    public partial class Qry30Frm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext ds = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        #region -   Functions   -
        public Qry30Frm()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -
        private void QryTblAhteatyFrm_Load(object sender, EventArgs e)
        {
            LSMSData.QueryableSource = from q in ds.vTBLMandoops where q.active == true select q;
            gridViewData.BestFitColumns();
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
       
        #endregion

    }
}