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
using DevExpress.XtraSplashScreen;

namespace RetirementCenter
{
    public partial class Qry21Frm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();

        #region -   Functions   -
        public Qry21Frm()
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
        private void btnView_Click(object sender, EventArgs e)
        {
            if (LUETBLDofatSarf.EditValue == null || LUESyndicateId.EditValue == null)
                return;
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                qry21TableAdapter.Fill(dsQueries.Qry21, Convert.ToInt32(LUETBLDofatSarf.EditValue), Convert.ToInt32(LUESyndicateId.EditValue));
                lblSum.Text = (Convert.ToDouble(COUNTWSpinEdit.Text) + Convert.ToDouble(COUNTMWSpinEdit.Text)).ToString();
            }));
            SplashScreenManager.CloseForm();
        }
      
        #endregion


    }
}
