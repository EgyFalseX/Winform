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
    public partial class Qry28Frm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Functions   -
        public Qry28Frm()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -
        private void QryTblAhteatyFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTeachersUnionQuery.Qry28' table. You can move, or remove it, as needed.
            this.qry28TableAdapter.Fill(this.dsTeachersUnionQuery.Qry28);
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
        private void gridViewData_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName != "gcDeff")
                return;
            if (Convert.ToInt32(e.CellValue) <= -1)
            {
                e.Appearance.BackColor = Color.Red;
            }
        }
        #endregion

    }
}