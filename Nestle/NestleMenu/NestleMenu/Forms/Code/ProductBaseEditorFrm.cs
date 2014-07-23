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
    public partial class ProductBaseEditorFrm : DevExpress.XtraEditors.XtraForm
    {
        #region - Var -
        #endregion
        #region - Fun -
        public ProductBaseEditorFrm()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            this.productBaseTableAdapter.Fill(this.dsNU.ProductBase);
            gridViewMain.BestFitColumns();
        }
        #endregion
        #region -  EventWhnd - 
        private void AreaEditorFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DataSources.dsNU.ProductBaseRow row = dsNU.ProductBase.NewProductBaseRow();
                row.ProductBaseId = -1;
                ProductBaseEditorWFrm frm = new ProductBaseEditorWFrm(row);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
                row.ProductBaseId = (int)productBaseTableAdapter.NewId();
                dsNU.ProductBase.AddProductBaseRow(row);
                row.EndEdit();
                productBaseTableAdapter.Update(row);
                NU.LogMessage("New Product Base Added ...", this, Utilities.Types.MessageType.Success, Utilities.Types.MessagePopupType.Alert);
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
                DataSources.dsNU.ProductBaseRow row = (DataSources.dsNU.ProductBaseRow)((DataRowView)gridViewMain.GetRow(gridViewMain.FocusedRowHandle)).Row;
                ProductBaseEditorWFrm frm = new ProductBaseEditorWFrm(row);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
                row.EndEdit();
                productBaseTableAdapter.Update(row);
                NU.LogMessage("Product Base Changed ...", this, Utilities.Types.MessageType.Success, Utilities.Types.MessagePopupType.Alert);
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
                DataSources.dsNU.ProductBaseRow row = (DataSources.dsNU.ProductBaseRow)((DataRowView)gridViewMain.GetRow(gridViewMain.FocusedRowHandle)).Row;
                if (row.RowState == DataRowState.Added || row.RowState == DataRowState.Detached)
                    return;
                productBaseTableAdapter.Delete(row.ProductBaseId);
                gridViewMain.DeleteRow(gridViewMain.FocusedRowHandle);
                NU.LogMessage("Product Base Deleted ...", this, Utilities.Types.MessageType.Success, Utilities.Types.MessagePopupType.Alert);

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
