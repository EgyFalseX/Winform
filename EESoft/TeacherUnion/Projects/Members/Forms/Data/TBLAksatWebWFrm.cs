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
    public partial class TBLAksatWebWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsTeachersUnion.TBLAksatWEBRow _row;
        public TBLAksatWebWFrm()
        {
            InitializeComponent();
        }
        public TBLAksatWebWFrm(DataSources.dsTeachersUnion.TBLAksatWEBRow row)
        {
            InitializeComponent();
            _row = row;
        }
        private void LoadBinding()
        {
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
            LoadBinding();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

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

            if (_row.IsNull("kestenddate") || _row.IsNull("mostahk") || _row.IsNull("madfoaa") || _row.IsNull("esalno") || _row.IsNull("esaldate"))
            {
                Program.Logger.LogThis("تفاصيل التقسيط غير مكتملة", Text, FXFW.Logger.OpType.fail, null, null, this);
                return;
            }

            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}