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
using NestleICSales.Utilities;
using DevExpress.Xpo.Metadata;
using DevExpress.XtraSplashScreen;

namespace NestleICSales.Forms.Code
{
    public partial class CityEditorFrm : DevExpress.XtraEditors.XtraForm
    {
        #region - Var -
        #endregion
        #region - Fun -
        public CityEditorFrm()
        {
            InitializeComponent();
            
        }
        void LoadData()
        {
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            System.Threading.ThreadPool.QueueUserWorkItem((o) => 
            {
                gridControlMain.Invoke(new MethodInvoker(() => {
                    //gridControlMain.DataSource = XPSCS;
                    cityTableAdapter.Fill(dsData.City);
                    gridViewMain.BestFitColumns();
                }));
                SplashScreenManager.CloseForm();
            });
        }
        #endregion
        #region -  EventWhnd - 
        private void Frm_Load(object sender, EventArgs e)
        {
        }
        private void Frm_Shown(object sender, EventArgs e)
        {
            LoadData();
        }
        private void gridViewMain_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataSources.dsData.CityRow row = (DataSources.dsData.CityRow)((DataRowView)gridViewMain.GetRow(e.RowHandle)).Row;
            object obj = dsData.City.Compute("Max(CityId)", "CityId <> " + Managers.DataManager.UnknownCityId);
            if (obj == null)
                row.CityId = 1;
            else
                row.CityId = Convert.ToInt32(obj) + 1;

        }
        private void repositoryItemButtonEditEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //try
            //{
            //    DataSources.dsGM.ItemRow row = (DataSources.dsGM.ItemRow)((DataRowView)gridViewMain.GetRow(gridViewMain.FocusedRowHandle)).Row;
            //    ItemEditorWFrm frm = new ItemEditorWFrm(row);
            //    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            //        return;
            //    row.EndEdit();
            //    itemTableAdapter.Update(row);
            //    Glob.LogMessage("تم تعديل الصنف ...", this, Utilities.Types.MessageType.Success, Utilities.Types.MessagePopupType.Alert);
            //}
            //catch (Exception ex)
            //{
            //    Glob.LogMessage(ex.Message, this, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.Message, ex);
            //}
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            //    return;
            //try
            //{
            //    DataSources.dsGM.ItemRow row = (DataSources.dsGM.ItemRow)((DataRowView)gridViewMain.GetRow(gridViewMain.FocusedRowHandle)).Row;
            //    if (row.RowState == DataRowState.Added || row.RowState == DataRowState.Detached)
            //        return;
            //    itemTableAdapter.Delete(row.ItemId);
            //    gridViewMain.DeleteRow(gridViewMain.FocusedRowHandle);
            //    Glob.LogMessage("تم حذف الصنف ...", this, Utilities.Types.MessageType.Success, Utilities.Types.MessagePopupType.Alert);

            //}
            //catch (Exception ex)
            //{
            //    Glob.LogMessage(ex.Message, this, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.Message, ex);
            //}
        }
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MsgDlg.Show("Are You Sure ?", Types.MessageType.Question) == System.Windows.Forms.DialogResult.No)
                return;
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm)); SplashScreenManager.Default.SetWaitFormDescription("Saving ...");
            cityTableAdapter.Update(dsData.City);
            SplashScreenManager.CloseForm();
            MsgDlg.ShowAlert("Data Saved ...", Types.MessageType.Success, this);
        }
        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!gridControlMain.IsPrintingAvailable)
            {
                MsgDlg.Show("The 'DevExpress.XtraPrinting' library is not found", Types.MessageType.Warn);
                return;
            }
            // Open the Preview window.
            gridControlMain.ShowRibbonPrintPreview();
        }
        #endregion

    }
        
} 
