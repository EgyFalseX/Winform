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
    public partial class Qry005 : DevExpress.XtraEditors.XtraForm
    {
        public Qry005()
        {
            InitializeComponent();
        }

        private void btnPrintExport_Click(object sender, EventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!gridControlData.IsPrintingAvailable)
            {
                Program.ShowMsg("The 'DevExpress.XtraPrinting' library is not found", true, this);
                return;
            }

            // Open the Preview window.
            gridControlData.ShowRibbonPrintPreview();
        }

        private void Qry001_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSFellowshipQuery.vQry005' table. You can move, or remove it, as needed.
            this.vQry005TableAdapter.Fill(this.dSFellowshipQuery.vQry005);

        }
    }
}