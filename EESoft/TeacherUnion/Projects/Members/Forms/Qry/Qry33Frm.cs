using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;
using System.Linq;

namespace Members.Forms.Qry
{
    public partial class Qry33Frm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Functions   -
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        public Qry33Frm()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -
        private void QryTblAhteatyFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTeachersUnionQuery.vQry33' table. You can move, or remove it, as needed.
            this.vQry33TableAdapter.Fill(this.dsTeachersUnionQuery.vQry33);
            //gridViewData.BestFitColumns();
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