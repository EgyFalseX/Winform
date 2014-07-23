using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Fellowship.Data
{
    public partial class DeleteTblAllDataFrm : DevExpress.XtraEditors.XtraForm
    {
        public DeleteTblAllDataFrm()
        {
            InitializeComponent();
        }

        private void DeleteTblAllDataFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSFellowship.CDGov' table. You can move, or remove it, as needed.
            this.cDGovTableAdapter.Fill(this.dSFellowship.CDGov);
            // TODO: This line of code loads data into the 'dSFellowship.CDEDARET' table. You can move, or remove it, as needed.
            this.cDEDARETTableAdapter.Fill(this.dSFellowship.CDEDARET);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lue.EditValue == null)
            {
                return;
            }
            if (MessageBox.Show("هل انت متأكد؟", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            int edaraid = Convert.ToInt32(lue.EditValue);
            tblAllDataTableAdapter.DeleteByedaraid(edaraid);

            Program.ShowMsg("تم الحذف", false, this);
            Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
        }
    }
}