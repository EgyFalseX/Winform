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

namespace GM.Forms.Code
{
    public partial class PlumberEditorFrm : DevExpress.XtraEditors.XtraForm
    {
        #region - Var -
        #endregion
        #region - Fun -
        public PlumberEditorFrm()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            plumberTableAdapter.Fill(dsGM.Plumber);
            gridViewMain.BestFitColumns();
        }
        #endregion
        #region -  EventWhnd - 
        private void Frm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsGM.Area' table. You can move, or remove it, as needed.
            this.areaTableAdapter.Fill(this.dsGM.Area);
            LoadData();
        }
        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bool AutoOpen = false;
                do
                {
                    DataSources.dsGM.PlumberRow row = dsGM.Plumber.NewPlumberRow();

                    row.PlumberId = -1; row.AreaId = -1;
                    PlumberEditorWFrm frm = new PlumberEditorWFrm(row);
                    frm.ceAutoOpen.Checked = AutoOpen;
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                        return;
                    row.PlumberId = (int)plumberTableAdapter.NewId();
                    dsGM.Plumber.AddPlumberRow(row);
                    row.EndEdit();
                    plumberTableAdapter.Update(row);
                    Glob.LogMessage("تم اضافة السباك ...", this, Utilities.Types.MessageType.Success, Utilities.Types.MessagePopupType.Alert);

                    AutoOpen = frm.ceAutoOpen.Checked;

                } while (AutoOpen);
                
            }
            catch (Exception ex)
            {
                Glob.LogMessage(ex.Message, this, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.Message, ex);
            }
        }
        private void repositoryItemButtonEditEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                DataSources.dsGM.PlumberRow row = (DataSources.dsGM.PlumberRow)((DataRowView)gridViewMain.GetRow(gridViewMain.FocusedRowHandle)).Row;
                PlumberEditorWFrm frm = new PlumberEditorWFrm(row);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
                row.EndEdit();
                plumberTableAdapter.Update(row);
                Glob.LogMessage("تم تعديل السباك ...", this, Utilities.Types.MessageType.Success, Utilities.Types.MessagePopupType.Alert);
            }
            catch (Exception ex)
            {
                Glob.LogMessage(ex.Message, this, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.Message, ex);
            }
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                DataSources.dsGM.PlumberRow row = (DataSources.dsGM.PlumberRow)((DataRowView)gridViewMain.GetRow(gridViewMain.FocusedRowHandle)).Row;
                if (row.RowState == DataRowState.Added || row.RowState == DataRowState.Detached)
                    return;
                plumberTableAdapter.Delete(row.PlumberId);
                gridViewMain.DeleteRow(gridViewMain.FocusedRowHandle);
                Glob.LogMessage("تم حذف السباك ...", this, Utilities.Types.MessageType.Success, Utilities.Types.MessagePopupType.Alert);

            }
            catch (Exception ex)
            {
                Glob.LogMessage(ex.Message, this, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.Message, ex);
            }
        }
        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!gridControlMain.IsPrintingAvailable)
            {
                Glob.LogMessage("The 'DevExpress.XtraPrinting' library is not found", this, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.Message);
                return;
            }
            // Open the Preview window.
            gridControlMain.ShowRibbonPrintPreview();
        }
        #endregion
    }
        
} 
