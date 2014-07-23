using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace NestleMenu.Forms.Code
{
    public partial class CustomersEditorFrm : DevExpress.XtraEditors.XtraForm
    {
        #region - Var -
        #endregion
        #region - Fun -
        public CustomersEditorFrm()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            this.customersTableAdapter.Fill(this.dsNU.Customers);
            gridViewMain.BestFitColumns();
        }
        #endregion
        #region -  EventWhnd - 
        private void JobEditorFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DataSources.dsNU.CustomersRow row = dsNU.Customers.NewCustomersRow();
                row.CustomerId = -1;
                CustomersEditorWFrm frm = new CustomersEditorWFrm(row);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
                row.CustomerId = (int)customersTableAdapter.NewId();
                dsNU.Customers.AddCustomersRow(row);
                row.EndEdit();
                customersTableAdapter.Update(row);
                NU.LogMessage("New Customers Added ...", this, Utilities.Types.MessageType.Success, Utilities.Types.MessagePopupType.Alert);
            }
            catch (Exception ex)
            {
                NU.LogMessage(ex.Message, this, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.Message, ex);
            }
        }
        private void repositoryItemButtonEditEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                DataSources.dsNU.CustomersRow row = (DataSources.dsNU.CustomersRow)((DataRowView)gridViewMain.GetRow(gridViewMain.FocusedRowHandle)).Row;
                CustomersEditorWFrm frm = new CustomersEditorWFrm(row);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
                row.EndEdit();
                customersTableAdapter.Update(row);
                NU.LogMessage("Customers Changed ...", this, Utilities.Types.MessageType.Success, Utilities.Types.MessagePopupType.Alert);
            }
            catch (Exception ex)
            {
                NU.LogMessage(ex.Message, this, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.Message, ex);
            }
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (msgDlg.Show("Are You Sure?", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                DataSources.dsNU.CustomersRow row = (DataSources.dsNU.CustomersRow)((DataRowView)gridViewMain.GetRow(gridViewMain.FocusedRowHandle)).Row;
                if (row.RowState == DataRowState.Added || row.RowState == DataRowState.Detached)
                    return;
                customersTableAdapter.Delete(row.CustomerId);
                gridViewMain.DeleteRow(gridViewMain.FocusedRowHandle);
                NU.LogMessage("Customers Deleted ...", this, Utilities.Types.MessageType.Success, Utilities.Types.MessagePopupType.Alert);

            }
            catch (Exception ex)
            {
                NU.LogMessage(ex.Message, this, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.Message, ex);
            }
        }
        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!gridControlMain.IsPrintingAvailable)
            {
                NU.LogMessage("The 'DevExpress.XtraPrinting' library is not found", this, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.Message);
                return;
            }
            // Open the Preview window.
            gridControlMain.ShowRibbonPrintPreview();
        }
        #endregion

    }
}
