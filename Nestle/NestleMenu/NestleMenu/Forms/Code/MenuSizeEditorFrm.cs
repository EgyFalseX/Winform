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
    public partial class MenuSizeEditorFrm : DevExpress.XtraEditors.XtraForm
    {
        #region - Var -
        #endregion
        #region - Fun -
        public MenuSizeEditorFrm()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            this.menuSizeTableAdapter.Fill(this.dsNU.MenuSize);
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
                DataSources.dsNU.MenuSizeRow row = dsNU.MenuSize.NewMenuSizeRow();
                row.MenuSizeId = -1; row.Disabled = false;
                MenuSizeEditorWFrm frm = new MenuSizeEditorWFrm(row);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
                row.MenuSizeId = (int)menuSizeTableAdapter.NewId();
                dsNU.MenuSize.AddMenuSizeRow(row);
                row.EndEdit();
                menuSizeTableAdapter.Update(row);
                NU.LogMessage("New Menu Size Added ...", this, Utilities.Types.MessageType.Success, Utilities.Types.MessagePopupType.Alert);
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
                DataSources.dsNU.MenuSizeRow row = (DataSources.dsNU.MenuSizeRow)((DataRowView)gridViewMain.GetRow(gridViewMain.FocusedRowHandle)).Row;
                MenuSizeEditorWFrm frm = new MenuSizeEditorWFrm(row);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
                row.EndEdit();
                menuSizeTableAdapter.Update(row);
                NU.LogMessage("Menu Size Changed ...", this, Utilities.Types.MessageType.Success, Utilities.Types.MessagePopupType.Alert);
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
                DataSources.dsNU.MenuSizeRow row = (DataSources.dsNU.MenuSizeRow)((DataRowView)gridViewMain.GetRow(gridViewMain.FocusedRowHandle)).Row;
                if (row.RowState == DataRowState.Added || row.RowState == DataRowState.Detached)
                    return;
                menuSizeTableAdapter.Delete(row.MenuSizeId);
                gridViewMain.DeleteRow(gridViewMain.FocusedRowHandle);
                NU.LogMessage("Menu Size Deleted ...", this, Utilities.Types.MessageType.Success, Utilities.Types.MessagePopupType.Alert);

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
