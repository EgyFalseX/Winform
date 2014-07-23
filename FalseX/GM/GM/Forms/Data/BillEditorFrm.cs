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
using DevExpress.Xpo.Metadata;
using DevExpress.Xpo;

namespace GM.Forms.Code
{
    public partial class BillEditorFrm : DevExpress.XtraEditors.XtraForm
    {
        #region - Var -
        #endregion
        #region - Fun -
        public BillEditorFrm()
        {
            InitializeComponent();

            LoadDefaultData();

            sessionData.ConnectionString = Properties.Settings.Default.GmKadryConnectionString;
            xpDSData.Session.TrackPropertiesModifications = true;

            gridViewMain.BestFitColumns();
        }
        void LoadDefaultData()
        {
            // TODO: This line of code loads data into the 'dsGM.Trader' table. You can move, or remove it, as needed.
            this.traderTableAdapter.Fill(this.dsGM.Trader);
            // TODO: This line of code loads data into the 'dsGM.Plumber' table. You can move, or remove it, as needed.
            this.plumberTableAdapter.Fill(this.dsGM.Plumber);
            // TODO: This line of code loads data into the 'dsGM.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.dsGM.Employee);
            
        }
        void ReloadData()
        {
            xpDSData.Session.DropIdentityMap();
            xpDSData.Reload();
            
            //gridViewMain.RefreshData();
            //gridControlMain.RefreshDataSource();
        }
        #endregion
        #region -  EventWhnd - 
        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            try
            {
                bool AutoOpen = false;
                do
                {
                    BillEditorWFrm frm = new BillEditorWFrm();
                    frm.ceAutoOpen.Checked = AutoOpen;
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                        return;
                    ReloadData();
                    Glob.LogMessage("تم اضافة معاينة ...", this, Utilities.Types.MessageType.Success, Utilities.Types.MessagePopupType.Alert);
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
                XPDataTableObject row = gridViewMain.GetRow(gridViewMain.FocusedRowHandle) as XPDataTableObject;
                int BillId = (int)row.GetMemberValue("BillId");
                BillEditorWFrm frm = new BillEditorWFrm(BillId);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
                ReloadData();
                Glob.LogMessage("تم تعديل معاينة ...", this, Utilities.Types.MessageType.Success, Utilities.Types.MessagePopupType.Alert);
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
                XPDataTableObject row = gridViewMain.GetRow(gridViewMain.FocusedRowHandle) as XPDataTableObject;
                int BillId = (int)row.GetMemberValue("BillId");
                billTableAdapter.Delete(BillId);
                gridViewMain.DeleteRow(gridViewMain.FocusedRowHandle);

                ReloadData();
                Glob.LogMessage("تم حذف معاينة ...", this, Utilities.Types.MessageType.Success, Utilities.Types.MessagePopupType.Alert);
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
