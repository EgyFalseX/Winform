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
    public partial class Qry8Frm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Functions   -
        public Qry8Frm()
        {
            InitializeComponent();
        }
        private void LoadData(object obj)
        {
            gridControlData.Invoke(new MethodInvoker(delegate
                {
                    gridControlData.Enabled = false;
                }));

            DataTable dt = SQLProvider.SelectQry8();
            //for (int i = dt.Rows.Count - 1; i > -1; i--)
            //{
            //    int exists = 0;

            //    for (int i2 = 0; i2 < dt.Rows.Count; i2++)
            //    {
            //        if ((int)dt.Rows[i]["KideNumber"] == (int)dt.Rows[i]["KideNumber"])
            //            exists++;
            //    }
            //    if (exists <= 1)
            //        dt.Rows.RemoveAt(i);
            //}
            
            gridControlData.Invoke(new MethodInvoker(delegate
                {
                gridControlData.Enabled = true ;
                gridControlData.DataSource = dt;
                }));
            
        }
        #endregion
        #region -   Event Handlers   -
        private void QryTblAhteatyFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTeachersUnionQuery.Qry08' table. You can move, or remove it, as needed.
            this.qry08TableAdapter.Fill(this.dsTeachersUnionQuery.Qry08);
            ThreadPool.QueueUserWorkItem(LoadData);
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