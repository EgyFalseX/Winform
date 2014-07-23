using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using System.Linq;
using System.Runtime.Serialization;

namespace RetirementCenter
{
    public partial class Qry00Frm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        #region -   Functions   -
        public Qry00Frm()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -
        private void QryTblAhteatyFrm_Load(object sender, EventArgs e)
        {
            //if (Program.UserInfo.IsAdmin)
            //    LSMS.QueryableSource = dsLinq.vTBLMashats;
            //else
            //    LSMS.QueryableSource = from q in dsLinq.vTBLMashats where Program.UserInfo.Syndicates.Contains((int)q.SyndicateId) select q;
            
            
            LSMSTBLMashats.QueryableSource = dsLinq.TBLMashats;

            //gridViewTBLMashats.BestFitColumns();
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

        private void gridViewTBLMashats_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            return;
            if (e.FocusedRowHandle < 0)
                return;

            GridView gv = (GridView)sender;
            DataSources.Linq.TBLMashat member = (DataSources.Linq.TBLMashat)gv.GetRow(e.FocusedRowHandle);
            LinqServerModeSource lsms = new LinqServerModeSource();
            lsms.ElementType = typeof(DataSources.Linq.TBLWarasa);
            lsms.KeyExpression = "PersonId";
            lsms.QueryableSource = from q in dsLinq.TBLWarasas where q.MMashatId == member.MMashatId select q;
            //gv.datasou
        }

        #endregion

        private void gridViewTBLMashats_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            GridView gv = (GridView)sender;
            GridView gvdetail = (GridView)gv.GetDetailView(e.RowHandle, e.RelationIndex);
            DataSources.Linq.TBLMashat member = (DataSources.Linq.TBLMashat)gv.GetRow(e.RowHandle);
            LinqServerModeSource lsms = new LinqServerModeSource();
            lsms.ElementType = typeof(DataSources.Linq.TBLWarasa);
            lsms.KeyExpression = "PersonId";
            lsms.QueryableSource = from q in dsLinq.TBLWarasas where q.MMashatId == member.MMashatId select q;
            List<DataSources.Linq.TBLWarasa> query = (from q in dsLinq.TBLWarasas where q.MMashatId == member.MMashatId select q).ToList();
            //e.ChildList = dsLinq.TBLWarasas.ToList().Where(x => x.MMashatId == member.MMashatId).ToList();
            List<DataSources.Linq.TBLWarasa> xx = dsLinq.TBLWarasas.ToList().Where(x => x.MMashatId == member.MMashatId).ToList();
            e.ChildList = xx;

            DataTable dtl;

        }
        

    }
}