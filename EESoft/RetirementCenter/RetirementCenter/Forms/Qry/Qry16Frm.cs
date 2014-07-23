using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using FXFW;
using DevExpress.XtraGrid.Views.Grid;
using System.Linq;
using DevExpress.XtraGrid;

namespace RetirementCenter
{
    public partial class Qry16Frm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        DataSources.dsRetirementCenterTableAdapters.TBLReSarfWarasaTableAdapter adpSarf = new DataSources.dsRetirementCenterTableAdapters.TBLReSarfWarasaTableAdapter();

        #region -   Functions   -
        public Qry16Frm()
        {
            InitializeComponent();
        }
        private void ActivePriv()
        {
            return;
            //bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            //SqlDB.GetFormPriv("Retirement" + Name.Replace("Frm", ""), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            //gridControlData.Visible = Selecting;
            //if (Inserting || Updateing)
            //    repositoryItemButtonEditSave.Buttons[0].Enabled = true;
            //else
            //    repositoryItemButtonEditSave.Buttons[0].Enabled = false;
            //repositoryItemButtonEditDel.Buttons[0].Enabled = Deleting;
        }
        private void LoadTBLWarasaSarf()
        {
            if (LUETBLDofatSarf.EditValue != null && LUESyndicateId.EditValue != null && LUECDSubCommitte.EditValue != null)
                tBLWarasaSarfTableAdapter.FillByForDeff(dsRetirementCenter.TBLWarasaSarf, Convert.ToInt32(LUETBLDofatSarf.EditValue), Convert.ToInt32(LUECDSubCommitte.EditValue));
        }
        private void LoadReportTable()
        {
            if (LUETBLDofatSarf.EditValue != null && LUESyndicateId.EditValue != null && LUECDSubCommitte.EditValue != null)
                rep03TableAdapter.FillByForDeff(dsReports.Rep03, Convert.ToInt32(LUETBLDofatSarf.EditValue), Convert.ToInt32(LUECDSubCommitte.EditValue));
        }
        private void LoadDefaultData()
        {
            LSMSTBLDofatSarf.QueryableSource = from q in dsLinq.TBLDofatSarfs where q.dofclosed == false select q;
            LSMSCDSyndicate.QueryableSource = dsLinq.CDSyndicates;
        }
        #endregion
        #region - Event Handlers -
        private void TBLWarasaSarfFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
            LoadDefaultData();
        }
        double summaryTotal = 0;
        private void gridViewData_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            return;
            GridColumnSummaryItem item = e.Item as GridColumnSummaryItem;
            GridView view = sender as GridView;

            if (item.FieldName == "personName")
            {
                switch (e.SummaryProcess)
                {
                    case DevExpress.Data.CustomSummaryProcess.Start:
                        summaryTotal = 0;
                        break;
                    case DevExpress.Data.CustomSummaryProcess.Calculate:
                        double plus = Convert.ToDouble(view.GetRowCellValue(e.RowHandle, "monymonth")) -
                            Convert.ToDouble(view.GetRowCellValue(e.RowHandle, "rsmmonth")) -
                            Convert.ToDouble(view.GetRowCellValue(e.RowHandle, "estktaa")) -
                            Convert.ToDouble(view.GetRowCellValue(e.RowHandle, "eshtrakmonth"));
                        summaryTotal += plus;
                        break;
                    case DevExpress.Data.CustomSummaryProcess.Finalize:
                        e.TotalValue = summaryTotal;
                        break;
                }
            }
        }
        private void LUESyndicateId_EditValueChanged(object sender, EventArgs e)
        {
            LSMSCDSubCommitte.QueryableSource = from q in dsLinq.CDSubCommittes where q.SyndicateId == Convert.ToInt32(LUESyndicateId.EditValue) select q;
        }
        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (LUETBLDofatSarf.EditValue == null || LUESyndicateId.EditValue == null || LUECDSubCommitte.EditValue == null)
                return;
            LoadTBLWarasaSarf();
            LoadReportTable();
            List<DataSources.Linq.CompareSarf> Deffs = new List<DataSources.Linq.CompareSarf>();
            pbc.Visible = true;
            btnCompare.Enabled = false;
            pbc.EditValue = 0;
            pbc.Properties.Maximum = dsRetirementCenter.TBLWarasaSarf.Count;

            foreach (DataSources.dsRetirementCenter.TBLWarasaSarfRow Sarf in dsRetirementCenter.TBLWarasaSarf)
            {
                pbc.EditValue = Convert.ToInt32(pbc.EditValue) + 1;
                Application.DoEvents();

                List<DataSources.dsRetirementCenter.TBLWarasaSarfRow> MashatsSarf = dsRetirementCenter.TBLWarasaSarf.ToList().Where(x => x["MMashatId"].ToString() == Sarf["MMashatId"].ToString()).ToList();
                List<DataSources.dsReports.Rep03Row> MashatsRep = dsReports.Rep03.ToList().Where(x => x.MMashatId.ToString() == Sarf["MMashatId"].ToString()).ToList();
                if (MashatsSarf.Count != MashatsRep.Count)
                {
                    List<DataSources.Linq.CompareSarf> Exists = Deffs.Where(x => x.PersonId == Sarf.PersonId && x.DeffType == Misc.Types.DeffType.NotFound.ToString()).ToList();
                    if (Exists.Count != 0)
                    {
                        DataSources.Linq.CompareSarf def = new DataSources.Linq.CompareSarf()
                        {
                            MMashatId = Convert.ToInt32(Sarf["MMashatId"]),
                            sarfnumber = Sarf.sarfnumber,
                            DeffType = Misc.Types.DeffType.NotFound.ToString(),
                            monymonthR = 0,
                            rsmmonthR = 0,
                            eshtrakmonthR = 0,
                            estktaaR = 0,
                            monymonthS = 0,
                            rsmmonthS = 0,
                            eshtrakmonthS = 0,
                            estktaaS = 0
                        };
                        Deffs.Add(def);
                    }
                }
                
                double monymonthSarf = 0, rsmmonthSarf = 0, eshtrakmonthSarf = 0, estktaaSarf = 0;
                double monymonthRep = 0, rsmmonthRep = 0, eshtrakmonthRep = 0, estktaaRep = 0;
                foreach (DataSources.dsRetirementCenter.TBLWarasaSarfRow item in MashatsSarf)
                {
                    monymonthSarf += item.monymonth;
                    rsmmonthSarf += item.rsmmonth;
                    eshtrakmonthSarf += item.eshtrakmonth;
                    estktaaSarf += item.estktaa;
                }
                foreach (DataSources.dsReports.Rep03Row item in MashatsRep)
                {
                    monymonthRep += item.monymonth;
                    rsmmonthRep += item.rsmmonth;
                    eshtrakmonthRep += item.eshtrakmonth;
                    estktaaRep += item.estktaa;
                }
                if (monymonthSarf != monymonthRep || rsmmonthSarf != rsmmonthRep || eshtrakmonthSarf != eshtrakmonthRep || estktaaSarf != estktaaRep)
                {
                    DataSources.Linq.CompareSarf def = new DataSources.Linq.CompareSarf()
                    {
                        MMashatId = Convert.ToInt32(Sarf["MMashatId"]),
                        sarfnumber = Sarf.sarfnumber,
                        DeffType = Misc.Types.DeffType.Changes.ToString(),
                        monymonthR = monymonthRep,
                        rsmmonthR = rsmmonthRep,
                        eshtrakmonthR = eshtrakmonthRep,
                        estktaaR = estktaaRep,
                        monymonthS = monymonthSarf,
                        rsmmonthS = rsmmonthSarf,
                        eshtrakmonthS = eshtrakmonthSarf,
                        estktaaS = estktaaSarf
                    };
                    Deffs.Add(def);
                }
            }
            gridControlData.DataSource = Deffs;
            pbc.Visible = false;
            btnCompare.Enabled = true;
            pbc.EditValue = 0;
        }

        #endregion

    }
}
