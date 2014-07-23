using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Fellowship
{
    public partial class TblMemberWFrm : DevExpress.XtraEditors.XtraForm
    {

        DataSources.DSFellowship.TblMemberRow _row;

        public TblMemberWFrm()
        {
            InitializeComponent();
        }
        public TblMemberWFrm(DataSources.DSFellowship.TblMemberRow row)
        {
            InitializeComponent();
            _row = row;
        }
        private void LoadData()
        {
            // TODO: This line of code loads data into the 'dSFellowship.CDSyndicate' table. You can move, or remove it, as needed.
            this.cDSyndicateTableAdapter.Fill(this.dSFellowship.CDSyndicate);
            // TODO: This line of code loads data into the 'dSFellowship.CDEDARET' table. You can move, or remove it, as needed.
            this.cDEDARETTableAdapter.Fill(this.dSFellowship.CDEDARET);
            // TODO: This line of code loads data into the 'dSFellowship.CDState' table. You can move, or remove it, as needed.
            this.cDStateTableAdapter.Fill(this.dSFellowship.CDState);
            // TODO: This line of code loads data into the 'dSFellowship.CDJob' table. You can move, or remove it, as needed.
            this.cDJobTableAdapter.Fill(this.dSFellowship.CDJob);
        }
        private void LoadBinding()
        {
            if (!_row.IsNull("StateID"))
                lueStateID.EditValue = _row.StateID;
            if (!_row.IsNull("MemberName"))
                tbMemberName.EditValue = _row.MemberName;
            if (!_row.IsNull("BirthDate"))
                deBirthDate.EditValue = _row.BirthDate;
            if (!_row.IsNull("EhalaDate"))
                deEhalaDate.EditValue = _row.EhalaDate;
            if (!_row.IsNull("Kidnumber"))
                tbKidnumber.EditValue = _row.Kidnumber;
            if (!_row.IsNull("JobtitleID"))
                lueJobtitleID.EditValue = _row.JobtitleID;
            if (!_row.IsNull("EdaraId"))
                lueEdaraId.EditValue = _row.EdaraId;
            if (!_row.IsNull("SyndicateId"))
                lueSyndicateId.EditValue = _row.SyndicateId;
            if (!_row.IsNull("MemberAddress"))
                tbMemberAddress.EditValue = _row.MemberAddress;
            if (!_row.IsNull("Mobile"))
                tbMobile.EditValue = _row.Mobile;
        }
        private void TBLSheekWaredWFrm_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadBinding();
        }
        private void lueEdaraId_QueryPopUp(object sender, CancelEventArgs e)
        {
            DataSources.DSFellowship.CDEDARETDataTable dt = new DataSources.DSFellowship.CDEDARETDataTable();

            if (_row.IsNull("SyndicateId"))
                dt = cDEDARETTableAdapter.GetData();
            else
                dt = cDEDARETTableAdapter.GetDataBy(_row.SyndicateId);

            lueEdaraId.Properties.DataSource = dt;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Program.Logger.LogThis("بيانات رئيسيه فارغه. ارجو ادخال كل البيانات المطلوبه", Text, FXFW.Logger.OpType.fail, null, null, this);
            
            if (lueStateID.EditValue != null)
                _row.StateID = Convert.ToInt32(lueStateID.EditValue);
            if (tbMemberName.EditValue != null)
                _row.MemberName = Convert.ToString(tbMemberName.EditValue);
            if (deBirthDate.EditValue != null)
                _row.BirthDate = Convert.ToDateTime(deBirthDate.EditValue);
            if (deEhalaDate.EditValue != null)
                _row.EhalaDate = Convert.ToDateTime(deEhalaDate.EditValue);
            if (tbKidnumber.EditValue != null)
                _row.Kidnumber = Convert.ToInt32(tbKidnumber.EditValue);
            if (lueJobtitleID.EditValue != null)
                _row.JobtitleID = Convert.ToInt32(lueJobtitleID.EditValue);
            if (lueEdaraId.EditValue != null)
                _row.EdaraId = Convert.ToInt32(lueEdaraId.EditValue);
            if (lueSyndicateId.EditValue != null)
                _row.SyndicateId = Convert.ToInt32(lueSyndicateId.EditValue);
            if (tbMemberAddress.EditValue != null)
                _row.MemberAddress = Convert.ToString(tbMemberAddress.EditValue);

            if (tbMobile.EditValue != null)
                _row.Mobile = Convert.ToString(tbMobile.EditValue);

            _row.userin = Convert.ToInt32(FXFW.SqlDB.UserInfo.UserID);
            _row.datein = DateTime.Now;

            DialogResult = System.Windows.Forms.DialogResult.OK;

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

    }
}