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
    public partial class TBLUserMistakeWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsTeachersUnion.TBLUserMistakeRow _row;
        public TBLUserMistakeWFrm()
        {
            InitializeComponent();
        }
        public TBLUserMistakeWFrm(DataSources.dsTeachersUnion.TBLUserMistakeRow row)
        {
            InitializeComponent();
            _row = row;
        }
        private void LoadBinding()
        {
            if (!_row.IsNull("userid"))
                LUEuserid.EditValue = _row.userid;
            if (!_row.IsNull("WorkTypeId"))
                LUEWorkTypeId.EditValue = _row.WorkTypeId;
            if (!_row.IsNull("mistakenots"))
                tbmistakenots.EditValue = _row.mistakenots;
        }
        private void FormWFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTeachersUnion.CDWorkType' table. You can move, or remove it, as needed.
            this.cDWorkTypeTableAdapter.Fill(this.dsTeachersUnion.CDWorkType);
            // TODO: This line of code loads data into the 'dsTeachersUnion.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dsTeachersUnion.Users);
            LoadBinding();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;

            if (LUEuserid.EditValue != null)
                _row.userid = Convert.ToInt32(LUEuserid.EditValue);
            if (LUEWorkTypeId.EditValue != null)
                _row.WorkTypeId = Convert.ToByte(LUEWorkTypeId.EditValue);
            if (tbmistakenots.EditValue != null)
                _row.mistakenots = tbmistakenots.EditValue.ToString();
            
            _row.userin = Program.UserInfo.UserId;
            _row.datein = (DateTime)new DataSources.dsTeachersUnionQueryTableAdapters.ServerDateTimeTableAdapter().ScalarQueryServerDateTime();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}