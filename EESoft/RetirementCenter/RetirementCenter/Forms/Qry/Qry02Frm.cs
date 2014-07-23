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
    public partial class Qry02Frm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        #region -   Functions   -
        public Qry02Frm()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -
        private void QryTblAhteatyFrm_Load(object sender, EventArgs e)
        {
            LSMSCDMashHala.QueryableSource = dsLinq.CDMashHalas;

            
        }
        private void LUECDMashHala_EditValueChanged(object sender, EventArgs e)
        {
            if (LUECDMashHala.EditValue == null)
            {
                return;
            }
            if (LUECDMashHala.EditValue.ToString() == ((int)Misc.Types.CDMashHala.A3da2).ToString())
            {
                if (Program.UserInfo.IsAdmin)
                    LSMS.QueryableSource = dsLinq.vQry02s;
                else
                    LSMS.QueryableSource = from q in dsLinq.vQry02s where Program.UserInfo.Syndicates.Contains(q.SyndicateId) select q;
                gridViewData.BestFitColumns();
            }
            else
            {
                if (Program.UserInfo.IsAdmin)
                    LSMS.QueryableSource = dsLinq.vQry02as;
                else
                    LSMS.QueryableSource = from q in dsLinq.vQry02as where Program.UserInfo.Syndicates.Contains(q.SyndicateId) select q;
                gridViewData.BestFitColumns();
            }

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