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
    public partial class ProductEditorFrm : DevExpress.XtraEditors.XtraForm
    {
        #region - Var -
        #endregion
        #region - Fun -
        public ProductEditorFrm()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            // TODO: This line of code loads data into the 'dsNU.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.dsNU.Product);
            gridViewMain.BestFitColumns();
        }
        void LoadDefaultData()
        {
            // TODO: This line of code loads data into the 'dsNU.ProductBase' table. You can move, or remove it, as needed.
            this.productBaseTableAdapter.Fill(this.dsNU.ProductBase);
        }
        #endregion
        #region -  EventWhnd - 
        private void AreaEditorFrm_Load(object sender, EventArgs e)
        {
            LoadDefaultData();
            LoadData();
        }
        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DataSources.dsNU.ProductRow row = dsNU.Product.NewProductRow();
                row.ProductId = -1; row.ProductBaseId = -1; row.Disabled = false;
                ProductEditorWFrm frm = new ProductEditorWFrm(row);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
                row.ProductId = (int)productTableAdapter.NewId();
                dsNU.Product.AddProductRow(row);
                row.EndEdit();
                productTableAdapter.Update(row);
                NU.LogMessage("New Product Added ...", this, Utilities.Types.MessageType.Success, Utilities.Types.MessagePopupType.Alert);
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
                DataSources.dsNU.ProductRow row = (DataSources.dsNU.ProductRow)((DataRowView)gridViewMain.GetRow(gridViewMain.FocusedRowHandle)).Row;
                ProductEditorWFrm frm = new ProductEditorWFrm(row);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
                row.EndEdit();
                productTableAdapter.Update(row);
                NU.LogMessage("Product Changed ...", this, Utilities.Types.MessageType.Success, Utilities.Types.MessagePopupType.Alert);
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
                DataSources.dsNU.ProductRow row = (DataSources.dsNU.ProductRow)((DataRowView)gridViewMain.GetRow(gridViewMain.FocusedRowHandle)).Row;
                if (row.RowState == DataRowState.Added || row.RowState == DataRowState.Detached)
                    return;
                productTableAdapter.Delete(row.ProductId);
                gridViewMain.DeleteRow(gridViewMain.FocusedRowHandle);
                NU.LogMessage("Product Deleted ...", this, Utilities.Types.MessageType.Success, Utilities.Types.MessagePopupType.Alert);

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
