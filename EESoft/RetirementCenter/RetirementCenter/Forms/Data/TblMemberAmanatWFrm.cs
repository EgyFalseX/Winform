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
    public partial class TblMemberAmanatWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsRetirementCenter.TblMemberAmanatRow _row;
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        bool _Insert, _Update, _Delete;
        public TblMemberAmanatWFrm()
        {
            InitializeComponent();
        }
        public TblMemberAmanatWFrm(DataSources.dsRetirementCenter.TblMemberAmanatRow row, bool insert, bool update, bool delete)
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
                FillMemberData(_row.DofatSarfAId);
            }
            if (!_row.IsNull("MMashatId"))
                lueMMashatId.EditValue = _row.MMashatId;
            if (!_row.IsNull("amanatmony"))
                tbamanatmony.EditValue = _row.amanatmony;
            if (!_row.IsNull("amanatrem"))
                tbamanatrem.EditValue = _row.amanatrem;
        }
        private void FillMemberData(int DofatSarfAId)
        {
            if (DofatSarfAId < 1)
            {
                this.LSMSTBLMashat.ElementType = typeof(RetirementCenter.DataSources.Linq.vTBLMashat01_V1);
                LSMSTBLMashat.QueryableSource = dsLinq.vTBLMashat01_V1s;
            }
            else
            {
                this.LSMSTBLMashat.ElementType = typeof(RetirementCenter.DataSources.Linq.vTBLMashat01_V2);
                LSMSTBLMashat.QueryableSource = from q in dsLinq.vTBLMashat01_V2s where q.DofatSarfId == DofatSarfAId select q;
            }
        }
        private void FormWFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsRetirementCenter.CdDofaatAmanat' table. You can move, or remove it, as needed.
            this.cdDofaatAmanatTableAdapter.Fill(this.dsRetirementCenter.CdDofaatAmanat);
            ActivePriv();

            if (_row.RowState != DataRowState.Detached)
            {

            }
            LoadBinding();
        }
        private void lueDofatSarfAId_EditValueChanged(object sender, EventArgs e)
        {
            if (lueDofatSarfAId.EditValue == null || lueDofatSarfAId.EditValue.ToString() == string.Empty)
            {
                return;
            }
            FillMemberData(Convert.ToInt32(lueDofatSarfAId.EditValue));
           
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;

            if (lueDofatSarfAId.EditValue != null)
                _row.DofatSarfAId = Convert.ToInt32(lueDofatSarfAId.EditValue);
            if (lueMMashatId.EditValue != null)
                _row.MMashatId = Convert.ToInt32(lueMMashatId.EditValue);
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
