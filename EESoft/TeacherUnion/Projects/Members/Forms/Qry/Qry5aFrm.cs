using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace Members.Forms.Qry
{
    public partial class Qry5aFrm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Functions   -
        public Qry5aFrm()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            DataTable dt = SQLProvider.SelectQry5();
            gridControlData.DataSource = dt;
        }
        #endregion
        #region -   Event Handlers   -
        private void QryTblAhteatyFrm_Load(object sender, EventArgs e)
        {
            //this.qry05TableAdapter.Fill(this.dsTeachersUnionQuery.Qry05);
            LSMSMembers.QueryableSource = new DataSources.Linq.dsTeachersUnionViewsDataContext().vTBLMembersQry05s;
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