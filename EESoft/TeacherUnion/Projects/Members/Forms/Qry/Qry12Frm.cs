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
    public partial class Qry12Frm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Functions   -
        public Qry12Frm()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -
        private void QryTblAhteatyFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTeachersUnion.Qry12' table. You can move, or remove it, as needed.
            this.qry12TableAdapter.Fill(this.dsTeachersUnion.Qry12);
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