using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Members
{
    public partial class Qry6Frm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Functions   -
        public Qry6Frm()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            DataTable dt = SQLProvider.SelectQry6();
            gridControlData.DataSource = dt;
            btnPrintExport.Visible = Program.UserInfo.IsAdmin;
        }
        #endregion
        #region -   Event Handlers   -
        private void QryTblAhteatyFrm_Load(object sender, EventArgs e)
        {
            LoadData();
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