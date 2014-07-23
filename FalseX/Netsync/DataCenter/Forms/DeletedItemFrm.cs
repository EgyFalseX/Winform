using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DataCenter.Managers;

namespace DataCenter.Forms
{
    public partial class DeletedItemFrm : DevExpress.XtraEditors.XtraForm
    {

        #region -   Variables   -
        DataSources.Linq.dsDataCenterLinqDataContext ds;
        DataSources.dsDataCenterTableAdapters.ItemTableAdapter adpItem;
        DataSources.dsDataCenterTableAdapters.LogsTableAdapter adpLog;
        nsLib.Utilities.UpdateInfo notify = new nsLib.Utilities.UpdateInfo();
        #endregion
        #region -   Functions   -
        public DeletedItemFrm()
        {
            InitializeComponent();

            adpItem = new DataSources.dsDataCenterTableAdapters.ItemTableAdapter();
            adpLog = new DataSources.dsDataCenterTableAdapters.LogsTableAdapter();
            ds = new DataSources.Linq.dsDataCenterLinqDataContext();
            notify.AddItem(false); notify.AddItem(false); notify.OnItemChanged += info_OnItemChanged;
        }
        void LoadData()
        {
            LSMSData.QueryableSource = ds.vDeletedItems;
        }
        void info_OnItemChanged(int index, object value)
        {
            switch (index)
            {
                case 0://Complate
                    this.Invoke(new MethodInvoker(() =>
                    {
                        if ((bool)value)
                            DataCenterX.LogMessage("تم حذف الملف من الخادم", typeof(DeletedItemFrm), nsLib.Utilities.Types.MessageType.Success);
                        else
                            DataCenterX.LogMessage("لم يتم حذف الملف من الخادم", typeof(DeletedItemFrm), nsLib.Utilities.Types.MessageType.Error);
                    })
                   );
                    break;
                case 1://Cancel
                    if ((bool)value)
                        DataCenterX.LogMessage("تم الغاء حذف الملف من الخادم", typeof(DeletedItemFrm), nsLib.Utilities.Types.MessageType.Success);
                    break;
            }
            notify.OnItemChanged -= info_OnItemChanged;
        }
        #endregion
        #region - Event Handlers -
        private void FileTypeFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void gridViewData_CalcPreviewText(object sender, CalcPreviewTextEventArgs e)
        {
            if (e.Row == null)
                return;
            DataSources.Linq.vDeletedItem Item = (DataSources.Linq.vDeletedItem)e.Row;
            if (Item.Info == null || Item.Info == string.Empty)
                e.PreviewText = string.Empty;
            else
                e.PreviewText = Item.Info;
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.Linq.vDeletedItem Item = (DataSources.Linq.vDeletedItem)GV.GetRow(GV.FocusedRowHandle);
            try
            {
                if (adpItem.SetActiveTrue(UserManager.defaultInstance.UserInfo.UserID, Item.ItemId) > 0)
                {
                    DataCenterX.LogMessage("تم استرجاع الملف", typeof(DeletedItemFrm), nsLib.Utilities.Types.MessageType.Success, null, true);
                    AppManager.defaultInstance.LogOperation(nsLib.Utilities.Types.LogType.Item, Item.ItemId, nsLib.Utilities.Types.LogOpType.Update);
                }
                else
                    DataCenterX.LogMessage("لم يتم استرجاع الملف", typeof(DeletedItemFrm), nsLib.Utilities.Types.MessageType.Success, null, true);

                LSMSData.Reload();
            }
            catch (SqlException ex)
            {
                DataCenterX.LogMessage("لم يتم استرجاع الملف", typeof(DeletedItemFrm), nsLib.Utilities.Types.MessageType.Error, ex, true);
            }
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.Linq.vDeletedItem Item = (DataSources.Linq.vDeletedItem)GV.GetRow(GV.FocusedRowHandle);
            try
            {
                if (adpItem.Delete(Item.ItemId) > 0)
                {
                    DataCenterX.NSManager.C_DeleteFile(AppManager.defaultInstance.GetServerOption(nsLib.Utilities.Types.ServerOptions.FilesPath) + Item.PhysicalName, ref notify);
                    DataCenterX.LogMessage("تم حذف الملف", typeof(DeletedItemFrm), nsLib.Utilities.Types.MessageType.Success, null, true);
                    adpLog.DeleteItemLogs(Item.ItemId);
                    DataCenterX.LogMessage("تم حذف توثيق عمليات الملف", typeof(DeletedItemFrm), nsLib.Utilities.Types.MessageType.Success);
                }
                else
                    DataCenterX.LogMessage("لم يتم حذف الملف", typeof(DeletedItemFrm), nsLib.Utilities.Types.MessageType.Success, null, true);
                LSMSData.Reload();
            }
            catch (SqlException ex)
            {
                DataCenterX.LogMessage("لم يتم حذف الملف", typeof(DeletedItemFrm), nsLib.Utilities.Types.MessageType.Error, ex, true);
            }
        }
        #endregion
    
    }
}
