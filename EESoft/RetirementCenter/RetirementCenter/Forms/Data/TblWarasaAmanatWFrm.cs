using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.Linq;

namespace RetirementCenter
{
    public partial class TblWarasaAmanatWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsRetirementCenter.TblWarasaAmanatRow _row;
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        bool _Insert, _Update, _Delete;
        public TblWarasaAmanatWFrm()
        {
            InitializeComponent();
        }
        public TblWarasaAmanatWFrm(DataSources.dsRetirementCenter.TblWarasaAmanatRow row, bool insert, bool update, bool delete)
        {
            InitializeComponent();
            _row = row;
            _Insert = insert;
            _Update = update;
            _Delete = delete;
        }
        private void ActivePriv()
        {
        }
        private void LoadBinding()
        {
            if (!_row.IsNull("DofatSarfAId"))
            {
                lueDofatSarfAId.EditValue = _row.DofatSarfAId;
                FillWarasaData(_row.DofatSarfAId);
            }
            if (!_row.IsNull("PersonId"))
                luePersonId.EditValue = _row.PersonId;
            if (!_row.IsNull("amanatmony"))
                tbamanatmony.EditValue = _row.amanatmony;
            if (!_row.IsNull("amanatrem"))
                tbamanatrem.EditValue = _row.amanatrem;
        }
        private void FillWarasaData(int DofatSarfAId)
        {
            if (DofatSarfAId < 1)
            {
                this.LSMSTBLWarasa.ElementType = typeof(RetirementCenter.DataSources.Linq.vTBLWarasa01_V1);
                LSMSTBLWarasa.QueryableSource = dsLinq.vTBLWarasa01_V1s;
            }
            else
            {
                this.LSMSTBLWarasa.ElementType = typeof(RetirementCenter.DataSources.Linq.vTBLWarasa01_V2);
                LSMSTBLWarasa.QueryableSource = from q in dsLinq.vTBLWarasa01_V2s where q.DofatSarfId == DofatSarfAId select q;
            }
        }
        private void FormWFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsRetirementCenter.CdDofaatAmanat' table. You can move, or remove it, as needed.
            this.cdDofaatAmanatTableAdapter.Fill(this.dsRetirementCenter.CdDofaatAmanat);
            ActivePriv();
            LoadBinding();
        }
        private void lueDofatSarfAId_EditValueChanged(object sender, EventArgs e)
        {
            if (lueDofatSarfAId.EditValue == null || lueDofatSarfAId.EditValue.ToString() == string.Empty)
            {
                return;
            }
            FillWarasaData(Convert.ToInt32(lueDofatSarfAId.EditValue));
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;

            if (lueDofatSarfAId.EditValue != null)
                _row.DofatSarfAId = Convert.ToInt32(lueDofatSarfAId.EditValue);
            if (luePersonId.EditValue != null)
                _row.PersonId = Convert.ToInt32(luePersonId.EditValue);
            if (tbamanatrem.EditValue != null)
                _row.amanatrem = tbamanatrem.EditValue.ToString();
            if (tbamanatmony.EditValue != null)
                _row.amanatmony = Convert.ToDouble(tbamanatmony.EditValue);

            _row.datein = SQLProvider.ServerDateTime();
            _row.userin = Program.UserInfo.UserId;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
       
    }
}
