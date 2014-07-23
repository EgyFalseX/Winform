using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;

namespace Members.Forms.Qry
{
    public partial class Qry24Frm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Functions   -
        public Qry24Frm()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -
        private void QryTblAhteatyFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTeachersUnionQuery.Qry24' table. You can move, or remove it, as needed.
            this.qry24TableAdapter.Fill(this.dsTeachersUnionQuery.Qry24);
            btnPrintExport.Visible = Program.UserInfo.IsAdmin;
        }
        private void btnPrintExport_Click(object sender, EventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!chartControlMain.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }
            // Open the Preview window.
            chartControlMain.ShowRibbonPrintPreview();
            
        }
        #endregion
        
    }
}