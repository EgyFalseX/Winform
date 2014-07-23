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
    public partial class Qry18Frm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        DataSources.dsRetirementCenterTableAdapters.FromAccessTableAdapter adpAccess = new DataSources.dsRetirementCenterTableAdapters.FromAccessTableAdapter();
        DataSources.dsRetirementCenterTableAdapters.TBLWarasaSarfTableAdapter adpWSarf = new DataSources.dsRetirementCenterTableAdapters.TBLWarasaSarfTableAdapter();
        DataSources.dsRetirementCenterTableAdapters.TBLMemberSarfTableAdapter adpMSarf = new DataSources.dsRetirementCenterTableAdapters.TBLMemberSarfTableAdapter();
        
        string NotFoundInSQL = "غير موجود في السكول";
        string NotFoundInAccess = "غير موجود في الاكسس";
        string MoneyChanges = "مبالغ مختلفه";

        #region -   Functions   -
        public Qry18Frm()
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
        private void LoadData()
        {
            adpWSarf.FillByDofatSarfId_SubCommitteId(dsRetirementCenter.TBLWarasaSarf, 1, Convert.ToInt32(LUECDSubCommitte.EditValue));
            adpMSarf.FillByDofatSarfId_SubCommitteId(dsRetirementCenter.TBLMemberSarf, 1, Convert.ToInt32(LUECDSubCommitte.EditValue));
            adpAccess.FillBySubCommitteId(dsRetirementCenter.FromAccess, Convert.ToInt32(LUECDSubCommitte.EditValue));
        }
        private void LoadDefaultData()
        {
            LSMSTBLDofatSarf.QueryableSource = from q in dsLinq.TBLDofatSarfs where q.dofclosed == false select q;
            LSMSCDSyndicate.QueryableSource = dsLinq.CDSyndicates;
            LSMSCDSubCommitte.QueryableSource = dsLinq.CDSubCommittes;
            LSMSCDMashHala.QueryableSource = dsLinq.CDMashHalas;
        }
        #endregion
        #region - Event Handlers -
        private void TBLWarasaSarfFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
        }
        private void LUECDSubCommitte_Enter(object sender, EventArgs e)
        {
            if (LUESyndicateId.EditValue == null || LUESyndicateId.EditValue.ToString() == string.Empty)
            {
                return;
            }
            LSMSCDSubCommitte.QueryableSource = from q in dsLinq.CDSubCommittes where q.SyndicateId == Convert.ToInt32(LUESyndicateId.EditValue) select q;
        }
        private void Qry18Frm_Shown(object sender, EventArgs e)
        {
            LoadDefaultData();
        }
        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (LUECDSubCommitte.EditValue == null || LUECDSubCommitte.EditValue.ToString() == string.Empty || LUESyndicateId.Enabled == null || LUESyndicateId.Enabled.ToString() == string.Empty)
                return;

            LoadData();

            List<DataSources.Linq.CompareWithAccess> Deffs = new List<DataSources.Linq.CompareWithAccess>();
            pcProgress.Visible = true;
            btnCompare.Enabled = false;
            pbc.EditValue = 0;
            pbc.Properties.Maximum = dsRetirementCenter.FromAccess.Count + dsRetirementCenter.TBLWarasaSarf.Count + dsRetirementCenter.TBLMemberSarf.Count;
            lblMax.Text = pbc.Properties.Maximum.ToString();
            Application.DoEvents();

            //search if found in sql
            foreach (DataSources.dsRetirementCenter.FromAccessRow access in dsRetirementCenter.FromAccess)
            {
                pbc.EditValue = (int)pbc.EditValue + 1;
                lblValue.Text = pbc.EditValue.ToString();
                Application.DoEvents();

                if (access.MashHalaId == (byte)Misc.Types.CDMashHala.Warasa)
                {
                    List<DataSources.dsRetirementCenter.TBLWarasaSarfRow> WSarf =
                        dsRetirementCenter.TBLWarasaSarf.ToList().Where(x => x.sarfnumber == access.sarfnumber).ToList();
                    if (WSarf.Count == 0)
                    {
                        List<DataSources.Linq.CompareWithAccess> Exists = Deffs.Where(x => x.sarfnumber == access.sarfnumber && x.DeffType == NotFoundInSQL).ToList();
                        if (Exists.Count == 0)
                        {
                            DataSources.Linq.CompareWithAccess def = new DataSources.Linq.CompareWithAccess()
                            {
                                sarfnumber = access.sarfnumber, SyndicateId = access.SyndicateId, SubCommitteId = access.SubCommitteId,
                                DeffType = NotFoundInSQL, MashHalaId = access.MashHalaId, monymonthAccess = access.accsessmony
                            };
                            Deffs.Add(def);
                            continue;
                        }
                    }

                    List<DataSources.dsRetirementCenter.TBLWarasaSarfRow> WSarfDeff =
                        dsRetirementCenter.TBLWarasaSarf.ToList().Where(x => x.sarfnumber == access.sarfnumber).ToList();
                    double SqlSum = 0;
                    foreach (DataSources.dsRetirementCenter.TBLWarasaSarfRow item in WSarfDeff)
                    {
                        SqlSum += (item.monymonth - item.rsmmonth - item.eshtrakmonth - item.estktaa);
                    }
                    if (SqlSum != access.accsessmony)
                    {
                        DataSources.Linq.CompareWithAccess def = new DataSources.Linq.CompareWithAccess()
                        {
                            sarfnumber = access.sarfnumber, SyndicateId = access.SyndicateId, SubCommitteId = access.SubCommitteId,
                            DeffType = MoneyChanges, MashHalaId = access.MashHalaId, monymonthSQL = SqlSum,
                            monymonthAccess = access.accsessmony
                        };
                        Deffs.Add(def);
                    }

                }
                else
                {
                    List<DataSources.dsRetirementCenter.TBLMemberSarfRow> MSarf =
                        dsRetirementCenter.TBLMemberSarf.ToList().Where(x => x.sarfnumber == access.sarfnumber).ToList();
                    if (MSarf.Count == 0)
                    {
                        List<DataSources.Linq.CompareWithAccess> Exists = Deffs.Where(x => x.sarfnumber == access.sarfnumber && x.DeffType == NotFoundInSQL).ToList();
                        if (Exists.Count == 0)
                        {
                            DataSources.Linq.CompareWithAccess def = new DataSources.Linq.CompareWithAccess()
                            {
                                sarfnumber = access.sarfnumber,
                                SyndicateId = access.SyndicateId,
                                SubCommitteId = access.SubCommitteId,
                                DeffType = NotFoundInSQL,
                                MashHalaId = access.MashHalaId,
                                monymonthAccess = access.accsessmony
                            };
                            Deffs.Add(def);
                            continue;
                        }
                    }

                    List<DataSources.dsRetirementCenter.TBLMemberSarfRow> MSarfDeff = 
                        dsRetirementCenter.TBLMemberSarf.ToList().Where(x => x.sarfnumber == access.sarfnumber).ToList();
                    double SqlSum = 0;
                    foreach (DataSources.dsRetirementCenter.TBLMemberSarfRow item in MSarfDeff)
                    {
                        SqlSum += (item.monymonth - item.rsmmonth - item.eshtrakmonth - item.estktaa);
                    }
                    if (SqlSum != access.accsessmony)
                    {
                        DataSources.Linq.CompareWithAccess def = new DataSources.Linq.CompareWithAccess()
                        {
                            sarfnumber = access.sarfnumber,
                            SyndicateId = access.SyndicateId,
                            SubCommitteId = access.SubCommitteId,
                            DeffType = MoneyChanges,
                            MashHalaId = access.MashHalaId,
                            monymonthSQL = SqlSum,
                            monymonthAccess = access.accsessmony
                        };
                        Deffs.Add(def);
                    }

                }

            }
            //search if found in access
            foreach (DataSources.dsRetirementCenter.TBLWarasaSarfRow sqlW in dsRetirementCenter.TBLWarasaSarf)
            {
                pbc.EditValue = (int)pbc.EditValue + 1;
                Application.DoEvents();
                lblValue.Text = pbc.EditValue.ToString();

                List<DataSources.dsRetirementCenter.FromAccessRow> WSarf = dsRetirementCenter.FromAccess.ToList().Where(x => x.MashHalaId == (byte)Misc.Types.CDMashHala.Warasa &&
                    x.sarfnumber == sqlW.sarfnumber).ToList();

                if (WSarf.Count == 0)
                {
                    List<DataSources.Linq.CompareWithAccess> Exists = Deffs.Where(x => x.sarfnumber == sqlW.sarfnumber && x.DeffType == NotFoundInAccess).ToList();
                    if (Exists.Count == 0)
                    {
                        DataSources.Linq.CompareWithAccess def = new DataSources.Linq.CompareWithAccess()
                        {
                            sarfnumber = sqlW.sarfnumber,
                            SyndicateId = sqlW.SyndicateId,
                            SubCommitteId = sqlW.SubCommitteId,
                            DeffType = NotFoundInAccess,
                            MashHalaId = (byte)Misc.Types.CDMashHala.Warasa,
                            monymonthSQL = sqlW.monymonth
                            
                        };
                        Deffs.Add(def);
                    }
                }

            }
            foreach (DataSources.dsRetirementCenter.TBLMemberSarfRow sqlM in dsRetirementCenter.TBLMemberSarf)
            {
                pbc.EditValue = (int)pbc.EditValue + 1;
                Application.DoEvents();
                lblValue.Text = pbc.EditValue.ToString();

                List<DataSources.dsRetirementCenter.FromAccessRow> MSarf = dsRetirementCenter.FromAccess.ToList().Where(x => x.MashHalaId == (byte)Misc.Types.CDMashHala.A3da2 &&
                    x.sarfnumber == sqlM.sarfnumber).ToList();

                if (MSarf.Count == 0)
                {
                    List<DataSources.Linq.CompareWithAccess> Exists = Deffs.Where(x => x.sarfnumber == sqlM.sarfnumber && x.DeffType == NotFoundInAccess).ToList();
                    if (Exists.Count == 0)
                    {
                        DataSources.Linq.CompareWithAccess def = new DataSources.Linq.CompareWithAccess()
                        {
                            sarfnumber = sqlM.sarfnumber,
                            SyndicateId = sqlM.SyndicateId,
                            SubCommitteId = sqlM.SubCommitteId,
                            DeffType = NotFoundInAccess,
                            MashHalaId = (byte)Misc.Types.CDMashHala.A3da2,
                            monymonthSQL = sqlM.monymonth
                        };
                        Deffs.Add(def);
                    }
                }

                
            }

           
            gridControlData.DataSource = Deffs;
            pcProgress.Visible = false;
            btnCompare.Enabled = true;
            pbc.EditValue = 0;
        }

        #endregion

    }
}
