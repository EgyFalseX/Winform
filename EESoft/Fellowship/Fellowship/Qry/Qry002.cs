using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Fellowship.Qry
{
    public partial class Qry002 : DevExpress.XtraEditors.XtraForm
    {
        public Qry002()
        {
            InitializeComponent();
        }

        private void btnPrintExport_Click(object sender, EventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!pivotGridControlData.IsPrintingAvailable)
            {
                Program.ShowMsg("The 'DevExpress.XtraPrinting' library is not found", true, this);
                return;
            }

            // Open the Preview window.
            pivotGridControlData.ShowRibbonPrintPreview();
        }

        private void Qry001_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSFellowshipQuery.vQry002' table. You can move, or remove it, as needed.
            this.vQry002TableAdapter.Fill(this.dSFellowshipQuery.vQry002);
        }
    }
}