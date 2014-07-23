using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;

namespace Members
{
    public partial class Qry11WFrm : DevExpress.XtraEditors.XtraForm
    {
        int MemberId = 0;
        #region -   Functions   -
        public Qry11WFrm(int memberId)
        {
            InitializeComponent();
            MemberId = memberId;
        }
        #endregion
        #region -   Event Handlers   -
        private void QryTblAhteatyFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTeachersUnion.TBLMemberRemark' table. You can move, or remove it, as needed.
            this.tBLMemberRemarkTableAdapter.FillByMemberId(this.dsTeachersUnion.TBLMemberRemark, MemberId);
            btnPrintExport.Visible = Program.UserInfo.IsAdmin;

        }
        private void btnPrintExport_Click(object sender, EventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!gridControlData.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }

            // Open the Preview window.
            gridControlData.ShowRibbonPrintPreview();
        }
       
        #endregion

    }
}