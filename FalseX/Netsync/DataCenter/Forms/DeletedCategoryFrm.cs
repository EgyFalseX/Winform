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
    public partial class DeletedCategoryFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsDataCenterLinqDataContext ds;
        DataSources.dsDataCenterTableAdapters.CategoryTableAdapter adpCategory;
        DataSources.dsDataCenterTableAdapters.LogsTableAdapter adpLog;

        public DeletedCategoryFrm()
        {
            InitializeComponent();

            adpCategory = new DataSources.dsDataCenterTableAdapters.CategoryTableAdapter();
            adpLog = new DataSources.dsDataCenterTableAdapters.LogsTableAdapter();
            ds = new DataSources.Linq.dsDataCenterLinqDataContext();
        }
        
        void LoadData()
        {
            LSMSData.QueryableSource = ds.vDeletedCategories;
        }
        private void FileTypeFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void gridViewData_CalcPreviewText(object sender, CalcPreviewTextEventArgs e)
        {
            if (e.Row == null)
                return;
            DataSources.Linq.vDeletedCategory Item = (DataSources.Linq.vDeletedCategory)e.Row;
            if (Item.Info == null || Item.Info == string.Empty)
                e.PreviewText = string.Empty;
            else
                e.PreviewText = Item.Info;
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.Linq.vDeletedCategory Category = (DataSources.Linq.vDeletedCategory)GV.GetRow(GV.FocusedRowHandle);
            try
            {
                if (adpCategory.SetActiveTrue(UserManager.defaultInstance.UserInfo.UserID, Category.CategoryId) > 0)
                {
                    DataCenterX.LogMessage("تم استرجاع المجلد", typeof(DeletedCategoryFrm), nsLib.Utilities.Types.MessageType.Success, null, true);
                    AppManager.defaultInstance.LogOperation(nsLib.Utilities.Types.LogType.Categoy, Category.CategoryId, nsLib.Utilities.Types.LogOpType.Update);
                }
                else
                    DataCenterX.LogMessage("لم يتم استرجاع المجلد", typeof(DeletedCategoryFrm), nsLib.Utilities.Types.MessageType.Success, null, true);
                
                LSMSData.Reload();
            }
            catch (SqlException ex)
            {
                DataCenterX.LogMessage("لم يتم استرجاع المجلد", typeof(DeletedCategoryFrm), nsLib.Utilities.Types.MessageType.Error, ex, true);
            }
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.Linq.vDeletedCategory Category = (DataSources.Linq.vDeletedCategory)GV.GetRow(GV.FocusedRowHandle);
            try
            {
                if ((int)adpCategory.ScalarQueryCategoryCount(Category.CategoryId) > 0 || (int)adpCategory.ScalarQueryItemCount(Category.CategoryId) > 0)
                {
                    DataCenterX.LogMessage("لا يمكن حذف مجلد غير فارغ", typeof(DeletedCategoryFrm), nsLib.Utilities.Types.MessageType.Warn, null, true);
                    return;
                }
                if (adpCategory.Delete(Category.CategoryId) > 0)
                {
                    DataCenterX.LogMessage("تم حذف المجلد", typeof(DeletedCategoryFrm), nsLib.Utilities.Types.MessageType.Success, null, true);
                    adpLog.DeleteCategoryLogs(Category.CategoryId);
                    DataCenterX.LogMessage("تم حذف توثيق عمليات المجلد", typeof(DeletedCategoryFrm), nsLib.Utilities.Types.MessageType.Success);
                }
                else
                    DataCenterX.LogMessage("لم يتم حذف المجلد", typeof(DeletedCategoryFrm), nsLib.Utilities.Types.MessageType.Success, null, true);
                LSMSData.Reload();
            }
            catch (SqlException ex)
            {
                DataCenterX.LogMessage("لم يتم حذف المجلد", typeof(DeletedCategoryFrm), nsLib.Utilities.Types.MessageType.Error, ex, true);
            }
        }
        
    }
}
