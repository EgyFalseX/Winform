using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace Members
{
    public partial class TBLAksatWindowWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsTeachersUnion.TBLAksatRow _row;
        public TBLAksatWindowWFrm()
        {
            InitializeComponent();
        }
        public TBLAksatWindowWFrm(DataSources.dsTeachersUnion.TBLAksatRow row)
        {
            InitializeComponent();
            _row = row;
        }
        private void LoadBinding()
        {
            if (!_row.IsNull("MemberId"))
                LUEMemberId.EditValue = _row.MemberId;
            if (!_row.IsNull("kestenddate"))
                dekestenddate.EditValue = _row.kestenddate;
            if (!_row.IsNull("mostahk"))
                tbmostahk.EditValue = _row.mostahk;
            if (!_row.IsNull("madfoaa"))
                tbmadfoaa.EditValue = _row.madfoaa;
            if (!_row.IsNull("esalno"))
                tbesalno.EditValue = _row.esalno;
            if (!_row.IsNull("esaldate"))
                deesaldate.EditValue = _row.esaldate;
        }
        private void FormWFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTeachersUnion.TBLMembersList' table. You can move, or remove it, as needed.
            this.tBLMembersListTableAdapter.Fill(this.dsTeachersUnion.TBLMembersList);
            // TODO: This line of code loads data into the 'dsTeachersUnion.CDSyndicate' table. You can move, or remove it, as needed.
            this.cDSyndicateTableAdapter.Fill(this.dsTeachersUnion.CDSyndicate);
            LoadBinding();
        }
        private void LUEMemberId_EditValueChanged(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(LUEMemberId.EditValue))
            {
                lblSyndicate.Text = string.Empty;
                lblKideNumber.Text = string.Empty;
                return;
            }
            DataSources.dsTeachersUnion.TBLMembersListRow row = (DataSources.dsTeachersUnion.TBLMembersListRow)((DataRowView)LUEMemberId.GetSelectedDataRow()).Row;
            lblSyndicate.Text = row.Syndicate;
            lblKideNumber.Text = row.KideNumber.ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;

            if (LUEMemberId.EditValue != null)
            {
                _row.MemberId = Convert.ToInt32(LUEMemberId.EditValue);
                _row.Syndicate = lblSyndicate.Text;
                _row.KideNumber = Convert.ToInt32(lblKideNumber.Text);
            }
            if (dekestenddate.EditValue != null)
                _row.kestenddate = Convert.ToDateTime(dekestenddate.EditValue);
            if (tbmostahk.EditValue != null)
                _row.mostahk = Convert.ToDouble(tbmostahk.EditValue);
            if (tbmadfoaa.EditValue != null)
                _row.madfoaa = Convert.ToDouble(tbmadfoaa.EditValue);
            if (tbesalno.EditValue != null)
                _row.esalno = tbesalno.EditValue.ToString();
            if (deesaldate.EditValue != null)
                _row.esaldate = Convert.ToDateTime(deesaldate.EditValue);
            
            _row.userin = Program.UserInfo.UserId;
            _row.datein = SQLProvider.GetServerDateTime();

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}