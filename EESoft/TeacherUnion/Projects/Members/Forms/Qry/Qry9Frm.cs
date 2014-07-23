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
    public partial class Qry9Frm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Functions   -
        public Qry9Frm()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -
        private void QryTblAhteatyFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTeachersUnion.Qry9' table. You can move, or remove it, as needed.
            this.qry9TableAdapter.Fill(this.dsTeachersUnion.Qry9);
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
        private void repositoryItemButtonEditDetails_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataSources.dsTeachersUnion.Qry9Row row = (DataSources.dsTeachersUnion.Qry9Row)gridViewData.GetDataRow(gridViewData.FocusedRowHandle);
            TblMemberAttachFrm frm = new TblMemberAttachFrm(row.MemberId);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }
        #endregion

    }
}