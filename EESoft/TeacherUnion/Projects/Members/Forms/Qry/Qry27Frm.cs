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
    public partial class Qry27Frm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Functions   -
        public Qry27Frm()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -
        private void QryTblAhteatyFrm_Load(object sender, EventArgs e)
        {
            btnPrintExport.Visible = Program.UserInfo.IsAdmin;
        }
        private void btnGetData_Click(object sender, EventArgs e)
        {
            if (deDate.EditValue != null)
            {
                qry27TableAdapter.Fill(dsTeachersUnionQuery.Qry27, deDate.DateTime);
            }
            else
            {
                Program.Logger.LogThis("من فضلك اختر تاريخ للبحث", Text, FXFW.Logger.OpType.fail, null, null, this);
            }
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