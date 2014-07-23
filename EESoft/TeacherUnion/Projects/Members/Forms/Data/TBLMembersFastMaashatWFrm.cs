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
    public partial class TBLMembersFastMaashatWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsTeachersUnion.TBLMembersRow _row;
        bool _Insert, _Update, _Delete;
        public TBLMembersFastMaashatWFrm()
        {
            InitializeComponent();
        }
        public TBLMembersFastMaashatWFrm(DataSources.dsTeachersUnion.TBLMembersRow row, bool insert, bool update, bool delete, bool FocusOnDetails = false)
        {
            InitializeComponent();
            _row = row;
            _Insert = insert;
            _Update = update;
            _Delete = delete;
            if (FocusOnDetails)
                xtraTabControl1.SelectedTabPage = xtraTabPageDetails;
        }
        private void ActivePriv()
        {
            btnSave.Visible = _Update;
        }
        private void LoadBinding()
        {
            if (!_row.IsNull("MemberName"))
                tbMemberName.EditValue = _row.MemberName;
            if (!_row.IsNull("KideNumber"))
                tbKideNumber.EditValue = _row.KideNumber;
            if (!_row.IsNull("SyndicateId"))
                lueSyndicateId.EditValue = _row.SyndicateId;
            if (!_row.IsNull("SubCommitteId"))
                lueSubCommitteId.EditValue = _row.SubCommitteId;
            if (!_row.IsNull("JobtitleID"))
                lueJobtitleID.EditValue = _row.JobtitleID;
            if (!_row.IsNull("MemberNId"))
                tbMemberNId.EditValue = _row.MemberNId;
            if (!_row.IsNull("ShadetKed"))
                ceShadetKed.EditValue = _row.ShadetKed;
        }
        private void CheckIfMemberCardPrinted()
        {
            if (_row.RowState == DataRowState.Detached)
                return;
            DataSources.dsTeachersUnionTableAdapters.TBLPrintCardListTableAdapter adp = new DataSources.dsTeachersUnionTableAdapters.TBLPrintCardListTableAdapter();
            if (adp.ScalarQueryExistMemberId(_row.MemberId) == 1 && !Program.UserInfo.IsAdmin)
            {
                btnSave.Visible = false;
                btnSave.Enabled = false;
            }
        }
        private void FormWFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
            cDSyndicateTableAdapter.Fill(dsTeachersUnion.CDSyndicate);
            cDJobtitleTableAdapter.Fill(dsTeachersUnion.CDJobtitle);
            LoadBinding();
            CheckIfMemberCardPrinted();
        }
        private void lueSyndicateId_EditValueChanged(object sender, EventArgs e)
        {
            if (!FXFW.SqlDB.IsNullOrEmpty(lueSyndicateId.EditValue))
                this.cDSubCommitteTableAdapter.FillBySyndicateId(this.dsTeachersUnion.CDSubCommitte, Convert.ToInt32(lueSyndicateId.EditValue));
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_row.RowState == DataRowState.Detached)
            {
                if (new DataSources.dsTeachersUnionTableAdapters.TBLMembersTableAdapter().ScalarQueryExistsKideNumber(Convert.ToInt32(tbKideNumber.EditValue)) != 0)
                {
                    Program.ShowMsg("رقم القيد موجود مسبقا", true, this);
                    Program.Logger.LogThis("رقم القيد موجود مسبقا", Text, FXFW.Logger.OpType.fail, null, null, this);
                    return;
                }
            }
            else
            {
                if (new DataSources.dsTeachersUnionTableAdapters.TBLMembersTableAdapter().ScalarQueryExistsKideNumber_MemberId(Convert.ToInt32(tbKideNumber.EditValue), _row.MemberId) != 0)
                {
                    Program.ShowMsg("رقم القيد موجود مسبقا", true, this);
                    Program.Logger.LogThis("رقم القيد موجود مسبقا", Text, FXFW.Logger.OpType.fail, null, null, this);
                    return;
                }
            }

            DialogResult = System.Windows.Forms.DialogResult.OK;

            if (tbMemberName.EditValue != null)
                _row.MemberName = tbMemberName.EditValue.ToString();
            if (tbKideNumber.EditValue != null)
                _row.KideNumber = Convert.ToInt32(tbKideNumber.EditValue);
            if (lueSyndicateId.EditValue != null)
                _row.SyndicateId = Convert.ToInt32(lueSyndicateId.EditValue);
            if (lueSubCommitteId.EditValue != null)
                _row.SubCommitteId = Convert.ToInt32(lueSubCommitteId.EditValue);
            if (lueJobtitleID.EditValue != null)
                _row.JobtitleID = Convert.ToInt32(lueJobtitleID.EditValue);
            if (ceShadetKed.EditValue != null)
                _row.ShadetKed = ceShadetKed.Checked;

            if (tbMemberNId.EditValue != null)
            {
                _row.MemberNId = tbMemberNId.EditValue.ToString();
                List<object> ID = Misc.Misc.IDExtraction(tbMemberNId.EditValue.ToString());
                if (ID.Count == 3)
                {
                    _row.MemberGender = Convert.ToByte(ID[0]);
                    _row.BirthDate = Convert.ToDateTime(ID[1]);
                    //row.MemberaddresGov = Convert.ToByte(ID[2]);
                }
            }

            _row.img = Program.imgPath + tbKideNumber.EditValue + Program.imgExt;
            _row.RandomCard = new Random().Next(100, 999).ToString();
            _row.MemberShipNumber = (int)(new DataSources.dsTeachersUnionTableAdapters.TBLMembersTableAdapter().ScalarQueryNewMemberShipNumber());

            _row.userin = Program.UserInfo.UserId;
            _row.datein = (DateTime)new DataSources.dsTeachersUnionQueryTableAdapters.ServerDateTimeTableAdapter().ScalarQueryServerDateTime();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
      
    }
}
