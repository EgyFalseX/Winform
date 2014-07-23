using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace RetirementCenter.Forms.Data
{
    public partial class TBLWarasaSarf_arshefDeleteFrm : DevExpress.XtraEditors.XtraForm
    {
        public TBLWarasaSarf_arshefDeleteFrm()
        {
            InitializeComponent();
        }

        private void TBLMemberSarf_arshefDeleteFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsQueries.CDSyndicate' table. You can move, or remove it, as needed.
            this.cDSyndicateTableAdapter.Fill(this.dsQueries.CDSyndicate);
            // TODO: This line of code loads data into the 'dsQueries.TBLDofatSarf' table. You can move, or remove it, as needed.
            this.tBLDofatSarfTableAdapter.Fill(this.dsQueries.TBLDofatSarf);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lueDofatSarfId.EditValue == null || lueSyndicateId.EditValue == null)
            {
                msgDlg.Show("من فضلك اختر دفعه و فرعية", msgDlg.msgButtons.Close);
                return;
            }
            if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;

            int count = tblWarasaSarf_arshefTableAdapter.DeleteSyndicateId_DofatSarfId(Convert.ToInt32(lueDofatSarfId.EditValue), Convert.ToInt32(lueSyndicateId.EditValue));
            string msg = "تم حذف " + count + " عضو ";
            Program.ShowMsg(msg, false, this, true);
            Program.Logger.LogThis(msg, Text, FXFW.Logger.OpType.success, null, null, this);
        }
    }
}