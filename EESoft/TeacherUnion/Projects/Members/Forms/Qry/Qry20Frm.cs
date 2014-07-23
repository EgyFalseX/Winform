using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;
using DevExpress.XtraGrid.Views.Grid;

namespace Members
{
    public partial class Qry20Frm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Functions   -
        public Qry20Frm()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -
        private void QryTblAhteatyFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTeachersUnionQuery.Qry20' table. You can move, or remove it, as needed.
            this.qry20TableAdapter.Fill(this.dsTeachersUnionQuery.Qry20);
            btnPrintExport.Visible = Program.UserInfo.IsAdmin;
            gridControlData.Enabled = false;
            pbc.Properties.Maximum = dsTeachersUnionQuery.Qry20.Rows.Count;
            pbc.EditValue = 0;
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                System.Threading.Thread.Sleep(1000);
                for (int i = dsTeachersUnionQuery.Qry20.Rows.Count - 1; i >= 0; i--)
                {
                    DataSources.dsTeachersUnionQuery.Qry20Row row = (DataSources.dsTeachersUnionQuery.Qry20Row)dsTeachersUnionQuery.Qry20.Rows[i];
                    if (row.IsAttachNameNull() || row.AttachName == string.Empty)
                        continue;
                    if (System.IO.File.Exists(row.AttachName))
                    {
                        gridControlData.Invoke( new Action(() => { gridViewData.DeleteRow(i); }) );
                    }
                    pbc.Invoke(new Action(() => { pbc.EditValue = Convert.ToInt32(pbc.EditValue) + 1; }));
                }
                gridControlData.Invoke(
                    new Action(() =>
                    { 
                        gridControlData.Enabled = true;
                        pbc.EditValue = 0;
                    })
                    );
            });
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
        private void repositoryItemButtonEditEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsTeachersUnionQuery.Qry20Row Row = (DataSources.dsTeachersUnionQuery.Qry20Row)GV.GetFocusedDataRow();

            TblMemberAttachFrm frm = new TblMemberAttachFrm(Row.MemberId);
            frm.ShowDialog();
        }
        #endregion
        
    }
}