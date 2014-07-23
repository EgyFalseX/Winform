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
    public partial class TBLEmpWorkWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsTeachersUnion.TBLEmpWorkRow _row;
        public TBLEmpWorkWFrm()
        {
            InitializeComponent();
        }
        public TBLEmpWorkWFrm(DataSources.dsTeachersUnion.TBLEmpWorkRow row)
        {
            InitializeComponent();
            _row = row;
            if (_row.RowState == DataRowState.Detached)
            {
                ceclosed.Checked = false;
                ceclosed.Visible = false;
                ceclosed.Enabled = false;
            }
        }
        private void LoadBinding()
        {
            if (!_row.IsNull("SyndicateId"))
                lueSyndicateId.EditValue = _row.SyndicateId;
            if (!_row.IsNull("WorkTypeId"))
                LUEWorkTypeId.EditValue = _row.WorkTypeId;
            if (!_row.IsNull("wno"))
                tbwno.EditValue = _row.wno;
            if (!_row.IsNull("wrem"))
                tbwrem.EditValue = _row.wrem;
            if (!_row.IsNull("workdate"))
                deworkdate.EditValue = _row.workdate;
        }
        private void FormWFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTeachersUnion.CDWorkType' table. You can move, or remove it, as needed.
            this.cDWorkTypeTableAdapter.Fill(this.dsTeachersUnion.CDWorkType);
            // TODO: This line of code loads data into the 'dsTeachersUnion.CDSyndicate' table. You can move, or remove it, as needed.
            this.cDSyndicateTableAdapter.Fill(this.dsTeachersUnion.CDSyndicate);
            LoadBinding();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;

            if (lueSyndicateId.EditValue != null)
                _row.SyndicateId = Convert.ToInt32(lueSyndicateId.EditValue);
            if (LUEWorkTypeId.EditValue != null)
                _row.WorkTypeId = Convert.ToByte(LUEWorkTypeId.EditValue);
            if (tbwno.EditValue != null)
                _row.wno = Convert.ToInt32(tbwno.EditValue);
            if (tbwrem.EditValue != null)
                _row.wrem = tbwrem.EditValue.ToString();
            if (deworkdate.EditValue != null)
                _row.workdate = deworkdate.DateTime;
            if (ceclosed.EditValue != null)
                _row.closed = ceclosed.Checked;

            _row.userin = Program.UserInfo.UserId;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        private void ceclosed_CheckedChanged(object sender, EventArgs e)
        {
            if (ceclosed.Checked)
            {
                if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                    return;
                btnSave_Click(btnSave, EventArgs.Empty);
            }
        }

    }
}