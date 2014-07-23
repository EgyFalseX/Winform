using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System.Linq;
using DataCenter.Managers;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

namespace DataCenter.Forms
{
    public partial class ItemBrowserFrm : DevExpress.XtraEditors.XtraForm
    {

        #region -   Variables   -
        private DataCenter.DataSources.dsDataCenterTableAdapters.CategoryTableAdapter adpCat = new DataSources.dsDataCenterTableAdapters.CategoryTableAdapter();
        private DataSources.dsDataCenterTableAdapters.ItemTableAdapter adpItem = new DataSources.dsDataCenterTableAdapters.ItemTableAdapter();
        private DataSources.dsDataCenterTableAdapters.CategoryRoleTableAdapter AdpCatRole = new DataSources.dsDataCenterTableAdapters.CategoryRoleTableAdapter();
        private DataSources.dsDataCenterTableAdapters.CategoryUserTableAdapter AdpCatUser = new DataSources.dsDataCenterTableAdapters.CategoryUserTableAdapter();
        GridHitInfo hitInfoItem = null; TreeListHitInfo hitInfoCategory = null;
        #endregion
        #region -   Functions   -
        public ItemBrowserFrm()
        {
            InitializeComponent();
        }
        void LoadIconsFromDB()
        {
            DataSources.dsDataCenterTableAdapters.IconsTableAdapter adp = new DataSources.dsDataCenterTableAdapters.IconsTableAdapter();
            adp.Fill(dsDataCenter.Icons);
            foreach (DataSources.dsDataCenter.IconsRow item in dsDataCenter.Icons)
            {
                if (item.IsIconDataNull())
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    global::DataCenter.Properties.Resources.Category.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    Image img = Image.FromStream(ms);
                    img.Tag = sharedImageCollectionCategory.ImageSource.Images.Count;
                    sharedImageCollectionCategory.ImageSource.AddImage(img, item.IconId.ToString());
                }
                else
                {
                    Image img = Image.FromStream(new System.IO.MemoryStream(item.IconData));
                    img.Tag = sharedImageCollectionCategory.ImageSource.Images.Count;
                    sharedImageCollectionCategory.ImageSource.AddImage(img, item.IconId.ToString());
                }
            }
        }
        void InitTreeListControl(int CategoryId = -1)
        {
            SplashScreenManager.ShowForm(typeof(Forms.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CategoryDataBinding();
                if (CategoryId != -1)
                    FocusNode(CategoryId);
            }));
            SplashScreenManager.CloseForm();
        }
        void InitGridControl(int TreeIndex, int FocusedItemIndex = -1)
        {
            SplashScreenManager.ShowForm(typeof(Forms.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                ItemDataBinding(TreeIndex);
                if (FocusedItemIndex != -1)
                    FocusItem(FocusedItemIndex);
            }));
            SplashScreenManager.CloseForm();
        }
        void CategoryDataBinding()
        {
            tlCategory.ExpandAll();
            this.qryCategoryTableAdapter.Fill(this.dsQueries.QryCategory, UserManager.defaultInstance.UserInfo.UserID);
            tlCategory.BestFitColumns();
        }
        void ItemDataBinding(int index)
        {
            this.qryItemsTableAdapter.FillByCategoryId_UserId(this.dsQueries.QryItems, dsQueries.QryCategory[index].CategoryId, UserManager.defaultInstance.UserInfo.UserID);
            gridViewFiles.BestFitColumns();
        }
        void FocusNode(int CategoryId)
        {
            tlCategory.SetFocusedNode(tlCategory.FindNodeByKeyID(CategoryId));
        }        
        void FocusItem(int ItemId)
        {
            for (int i = 0; i < gridViewFiles.DataRowCount; i++)
            {
                DataSources.dsQueries.QryItemsRow row = (DataSources.dsQueries.QryItemsRow)gridViewFiles.GetDataRow(i);
                if (row.ItemId == ItemId)
                {
                    gridViewFiles.FocusedRowHandle = gridViewFiles.GetRowHandle(i);
                    return;
                }
            }
        }

        private void addSubCategory()
        {
            DataSources.dsDataCenter.CategoryRow row = dsDataCenter.Category.NewCategoryRow();
            row.ParentID = dsQueries.QryCategory[tlCategory.FocusedNode.Id].CategoryId;

            CategoryEditorDLG dlg = new CategoryEditorDLG(row);
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            try
            {
                row.CategoryId = (int)AppManager.defaultInstance.adpQry.ScalarQueryCategoryNewId();
                dsDataCenter.Category.AddCategoryRow(row);
                adpCat.Update(row);
                dsDataCenter.Category.AcceptChanges();
                DataManager.defaultInstance.AddDefaultCategoryAndInheritancePrivilages(row.CategoryId, row.ParentID);
                AppManager.defaultInstance.LogOperation(nsLib.Utilities.Types.LogType.Categoy, row.CategoryId, nsLib.Utilities.Types.LogOpType.Inset);
                //load Categories
                CategoryDataBinding(); FocusNode(row.CategoryId);
                DataCenterX.LogMessage("تم اضافة مجلد فرعي", typeof(ItemBrowserFrm), nsLib.Utilities.Types.MessageType.Success, null, true);
            }
            catch (SqlException ex)
            {
                DataCenterX.LogMessage("لم يتم اضافة مجلد فرعي", typeof(ItemBrowserFrm), nsLib.Utilities.Types.MessageType.Error, ex, true);
            }
        }
        private void addMainCategory()
        {
            DataSources.dsDataCenter.CategoryRow row = dsDataCenter.Category.NewCategoryRow();
            row.ParentID = 0; row.active = true;

            CategoryEditorDLG dlg = new CategoryEditorDLG(row);
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            try
            {
                row.CategoryId = (int)AppManager.defaultInstance.adpQry.ScalarQueryCategoryNewId();
                dsDataCenter.Category.AddCategoryRow(row);
                adpCat.Update(row);
                DataManager.defaultInstance.AddDefaultCategoryAndInheritancePrivilages(row.CategoryId);
                AppManager.defaultInstance.LogOperation(nsLib.Utilities.Types.LogType.Categoy, row.CategoryId, nsLib.Utilities.Types.LogOpType.Inset);
                //load Categories
                CategoryDataBinding(); FocusNode(row.CategoryId);
                DataCenterX.LogMessage("تم اضافة مجلد رئيسي", typeof(ItemBrowserFrm), nsLib.Utilities.Types.MessageType.Success, null, true);
            }
            catch (SqlException ex)
            {
                DataCenterX.LogMessage("لم يتم اضافة مجلد رئيسي", typeof(ItemBrowserFrm), nsLib.Utilities.Types.MessageType.Error, ex, true);
            }
        }
        private void deleteCategory()
        {
            int CategoryId = dsQueries.QryCategory[tlCategory.FocusedNode.Id].CategoryId;
            int ParentId = dsQueries.QryCategory[tlCategory.FocusedNode.Id].ParentID;
            if ((int)adpCat.ScalarQueryCategoryCount(CategoryId) > 0 || (int)adpCat.ScalarQueryItemCount(CategoryId) > 0)
            {
                DataCenterX.LogMessage("لا يمكن حذف مجلد غير فارغ", typeof(ItemBrowserFrm), nsLib.Utilities.Types.MessageType.Warn, null, true);
                return;
            }
            if (MessageBox.Show("هل انت متأكد؟", "تأكيـــــــد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                adpCat.SetActiveFalse(CategoryId);
                dsDataCenter.Category.AcceptChanges();
                AppManager.defaultInstance.LogOperation(nsLib.Utilities.Types.LogType.Categoy, CategoryId, nsLib.Utilities.Types.LogOpType.Delete);
                //load Categories
                CategoryDataBinding(); FocusNode(ParentId);
                DataCenterX.LogMessage("تم حذف المجلد", typeof(ItemBrowserFrm), nsLib.Utilities.Types.MessageType.Success, null, true);
            }
            catch (SqlException ex)
            {
                DataCenterX.LogMessage("لم يتم حذف المجلد", typeof(ItemBrowserFrm), nsLib.Utilities.Types.MessageType.Error, ex, true);
            }
        }
        private void categoryProperties()
        {
            DataSources.dsQueries.QryCategoryRow Cat = (DataSources.dsQueries.QryCategoryRow)((DataRowView)tlCategory.GetDataRecordByNode(tlCategory.FocusedNode)).Row;
            DataSources.dsDataCenter.CategoryRow row = adpCat.GetDataByCategoryId(dsQueries.QryCategory[tlCategory.FocusedNode.Id].CategoryId)[0];

            CategoryEditorDLG dlg = new CategoryEditorDLG(row);
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            try
            {
                adpCat.Update(row);
                dsDataCenter.Category.AcceptChanges();
                AppManager.defaultInstance.LogOperation(nsLib.Utilities.Types.LogType.Categoy, row.CategoryId, nsLib.Utilities.Types.LogOpType.Update);
                //load Categories
                CategoryDataBinding(); FocusNode(row.CategoryId);
                DataCenterX.LogMessage("تم تعديل المجلد", typeof(ItemBrowserFrm), nsLib.Utilities.Types.MessageType.Success, null, true);
            }
            catch (SqlException ex)
            {
                DataCenterX.LogMessage("لم يتم تعديل المجلد", typeof(ItemBrowserFrm), nsLib.Utilities.Types.MessageType.Error, ex, true);
            }
        }
        private void categoryPermission()
        {
            DataSources.dsQueries.QryCategoryRow Cat = (DataSources.dsQueries.QryCategoryRow)((DataRowView)tlCategory.GetDataRecordByNode(tlCategory.FocusedNode)).Row;
            DataSources.dsDataCenter.CategoryRow row = adpCat.GetDataByCategoryId(dsQueries.QryCategory[tlCategory.FocusedNode.Id].CategoryId)[0];

            CategoryPermissionEditorDLG dlg = new CategoryPermissionEditorDLG(row);
            dlg.ShowDialog();
            InitTreeListControl(Cat.CategoryId);
        }
        private void categoryHistory()
        {
            HistoryViewerDLG frm =
                new HistoryViewerDLG(nsLib.Utilities.Types.LogType.Categoy, dsQueries.QryCategory[tlCategory.FocusedNode.Id].CategoryId) 
                {
                    Text = "عمليات المجلد " + dsQueries.QryCategory[tlCategory.FocusedNode.Id].CategoryName,
                    MdiParent = this.ParentForm
                };
            frm.Show();
        }
        private void moveCategory(int CategoryId, int CurrentParent, int ParentId)
        {
            if (adpCat.UpdateChangeParentCategory(ParentId, UserManager.defaultInstance.UserInfo.UserID, CategoryId) > 0)
            {
                DataCenterX.LogMessage("تم نقل الملجد", typeof(ItemBrowserFrm), nsLib.Utilities.Types.MessageType.Success, null, true);

                AppManager.defaultInstance.LogOperation(nsLib.Utilities.Types.LogType.Categoy, CategoryId, nsLib.Utilities.Types.LogOpType.Update);
                DataCenterX.LogMessage("تم توثيق المجلد", typeof(ItemBrowserFrm), nsLib.Utilities.Types.MessageType.Debug);
                DataManager.defaultInstance.MoveCategoryInheritancePrivilages(CategoryId, ParentId);
                DataCenterX.LogMessage("تم تعديل صلاحيات المجلد", typeof(ItemBrowserFrm), nsLib.Utilities.Types.MessageType.Debug);
                //load Categories
                CategoryDataBinding(); FocusNode(CategoryId);
            }
            else
                DataCenterX.LogMessage("لم يتم نقل الملف", typeof(ItemBrowserFrm), nsLib.Utilities.Types.MessageType.Error, null, true);
        }

        private void addFile(string FilePath = "")
        {
            if (tlCategory.FocusedNode == null)
                return;
            DataSources.dsDataCenter.ItemRow row = dsDataCenter.Item.NewItemRow();
            row.CategoryId = dsQueries.QryCategory[tlCategory.FocusedNode.Id].CategoryId;
            ItemEditorDLG dlg = new ItemEditorDLG(row, FilePath);
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            try
            {
                row.ItemId = (int)AppManager.defaultInstance.adpQry.ScalarQueryItemNewId();
                dsDataCenter.Item.AddItemRow(row);
                itemTableAdapter.Update(row);
                dsDataCenter.Item.AcceptChanges();
                DataManager.defaultInstance.AddDefaultItemPrivilages(row.ItemId);
                AppManager.defaultInstance.LogOperation(nsLib.Utilities.Types.LogType.Item, row.ItemId, nsLib.Utilities.Types.LogOpType.Inset);
                DataCenterX.LogMessage("تم اضافة ملف", typeof(ItemBrowserFrm), nsLib.Utilities.Types.MessageType.Success, null, true);
                InitGridControl(tlCategory.FocusedNode.Id, row.ItemId);
            }
            catch (SqlException ex)
            {
                DataCenterX.LogMessage("لم يتم اضافة الملف", typeof(ItemBrowserFrm), nsLib.Utilities.Types.MessageType.Error, ex, true);
            }
        }
        private void viewFile()
        {
            if (gridViewFiles.SelectedRowsCount == 0)
                return;
            DataSources.dsQueries.QryItemsRow row = (DataSources.dsQueries.QryItemsRow)gridViewFiles.GetFocusedDataRow();

            switch (row.AssociationId)
            {
                case 0:
                    break;
                case 1:
                    ImageViewerFrm FrmImageViewer = new ImageViewerFrm(row) { MdiParent = this.ParentForm };
                     FrmImageViewer.Show();
                    break;
                case 2:
                    MSWordViewerFrm FrmMSWordViewer = new MSWordViewerFrm(row) { MdiParent = this.ParentForm };
                    FrmMSWordViewer.Show();
                    break;
            }
        }
        private void DeleteFile()
        {
            if (gridViewFiles.SelectedRowsCount == 0)
                return;
            DataSources.dsQueries.QryItemsRow Qrow = (DataSources.dsQueries.QryItemsRow)gridViewFiles.GetFocusedDataRow();
            DataSources.dsDataCenter.ItemRow row = itemTableAdapter.GetDataByItemId(Qrow.ItemId)[0];

            if (MessageBox.Show("هل انت متأكد؟", "تأكيـــــــد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                itemTableAdapter.SetActiveFalse(row.ItemId);
                gridViewFiles.DeleteSelectedRows();
                dsDataCenter.Item.AcceptChanges();
                AppManager.defaultInstance.LogOperation(nsLib.Utilities.Types.LogType.Item, row.ItemId, nsLib.Utilities.Types.LogOpType.Delete);
                DataCenterX.LogMessage("تم حذف الملف", typeof(ItemBrowserFrm), nsLib.Utilities.Types.MessageType.Success, null, true);
            }
            catch (SqlException ex)
            {
                DataCenterX.LogMessage("لم يتم حذف الملف", typeof(ItemBrowserFrm), nsLib.Utilities.Types.MessageType.Error, ex, true);
            }
        }
        private void FileProperites()
        {
            DataSources.dsQueries.QryItemsRow Qrow = (DataSources.dsQueries.QryItemsRow)gridViewFiles.GetFocusedDataRow();
            DataSources.dsDataCenter.ItemRow row = itemTableAdapter.GetDataByItemId(Qrow.ItemId)[0];

            ItemEditorDLG dlg = new ItemEditorDLG(row);
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            try
            {
                itemTableAdapter.Update(row);
                dsDataCenter.Item.AcceptChanges();
                AppManager.defaultInstance.LogOperation(nsLib.Utilities.Types.LogType.Item, row.ItemId, nsLib.Utilities.Types.LogOpType.Update);
                DataCenterX.LogMessage("تم تعديل الملف", typeof(ItemBrowserFrm), nsLib.Utilities.Types.MessageType.Success, null, true);
                InitGridControl(tlCategory.FocusedNode.Id, row.ItemId);
            }
            catch (SqlException ex)
            {
                DataCenterX.LogMessage("لم يتم تعديل الملف", typeof(ItemBrowserFrm), nsLib.Utilities.Types.MessageType.Error, ex, true);
            }
        }
        private void filePermission()
        {
            DataSources.dsQueries.QryItemsRow Qrow = (DataSources.dsQueries.QryItemsRow)gridViewFiles.GetFocusedDataRow();
            DataSources.dsDataCenter.ItemRow row = itemTableAdapter.GetDataByItemId(Qrow.ItemId)[0];

            ItemPermissionEditorDLG dlg = new ItemPermissionEditorDLG(row);
            dlg.ShowDialog();
            InitGridControl(tlCategory.FocusedNode.Id, row.ItemId);
        }
        private void fileHistory()
        {
            DataSources.dsQueries.QryItemsRow Qrow = (DataSources.dsQueries.QryItemsRow)gridViewFiles.GetFocusedDataRow();

            HistoryViewerDLG frm = new HistoryViewerDLG(nsLib.Utilities.Types.LogType.Item, Qrow.ItemId) 
            {
                Text = "عمليات الملف " + Qrow.ItemName,
                MdiParent = this.ParentForm 
            };
            frm.Show();
        }
        private void moveFile(DataSources.dsQueries.QryItemsRow item, int CategoryId)
        {
            if (adpItem.UpdateChangeCategory(CategoryId, UserManager.defaultInstance.UserInfo.UserID, item.ItemId) > 0)
            {
                DataCenterX.LogMessage("تم نقل الملف", typeof(ItemBrowserFrm), nsLib.Utilities.Types.MessageType.Success, null, true);
                AppManager.defaultInstance.LogOperation(nsLib.Utilities.Types.LogType.Item, item.ItemId, nsLib.Utilities.Types.LogOpType.Update);
                DataCenterX.LogMessage("تم توثيق العملية", typeof(ItemBrowserFrm), nsLib.Utilities.Types.MessageType.Debug);
                InitGridControl(tlCategory.FocusedNode.Id);
            }
            else
                DataCenterX.LogMessage("لم يتم نقل الملف", typeof(ItemBrowserFrm), nsLib.Utilities.Types.MessageType.Error, null, true);
        }
        #endregion
        #region - Event Handlers -
       
        #region - Menu Handlers -
        private void contextMenuStripCaterogy_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            addMainCategoryToolStripMenuItem.Enabled = false;
            addSubCategoryToolStripMenuItem.Enabled = false;
            deleteCategoryToolStripMenuItem.Enabled = false;
            categoryPropertiesToolStripMenuItem.Enabled = false;
            categoryAdminLevelToolStripMenuItem.Enabled = false;

            if (UserManager.defaultInstance.UserInfo.UserLevelId == (int)nsLib.Utilities.Types.UserLevelType.Administrator && tlCategory.AllNodesCount == 0)
                addMainCategoryToolStripMenuItem.Enabled = true;

            if (tlCategory.FocusedNode == null)
                return;

            DataSources.dsQueries.QryCategoryRow Category = dsQueries.QryCategory[tlCategory.FocusedNode.Id];

            if (Category.CanInsert == 1 && tlCategory.FocusedNode != null)
                addSubCategoryToolStripMenuItem.Enabled = true;

            if (Category.CanWrite == 1 && tlCategory.FocusedNode != null)
                categoryPropertiesToolStripMenuItem.Enabled = true;

            if (Category.CanDelete == 1 && tlCategory.FocusedNode != null)
                deleteCategoryToolStripMenuItem.Enabled = true;

            if (Category.UserLevelId == (int)nsLib.Utilities.Types.UserLevelType.Administrator && tlCategory.FocusedNode != null)
                categoryAdminLevelToolStripMenuItem.Enabled = true;
        }
        private void addSubCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addSubCategory();
        }
        private void addMainCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addMainCategory();
        }
        private void deleteCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteCategory();
        }
        private void categoryPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            categoryProperties();
        }
        private void categoryPermissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            categoryPermission();
        }
        private void categoryHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            categoryHistory();
        }

        private void contextMenuStripFile_Opening(object sender, CancelEventArgs e)
        {
            viewFileToolStripMenuItem.Enabled = false;
            addFileToolStripMenuItem.Enabled = false;
            DeleteFiletoolStripMenuItem.Enabled = false;
            FileProperitestoolStripMenuItem.Enabled = false;
            fileAdminLevelToolStripMenuItem.Enabled = false;

            if (tlCategory.FocusedNode == null)
                return;

            DataSources.dsQueries.QryCategoryRow Category = dsQueries.QryCategory[tlCategory.FocusedNode.Id];

            if (Category.CanInsert == 1)
                addFileToolStripMenuItem.Enabled = true;

            if (gridViewFiles.SelectedRowsCount == 0)
                return;

            DataSources.dsQueries.QryItemsRow Item = (DataSources.dsQueries.QryItemsRow)gridViewFiles.GetFocusedDataRow();
            if (Item == null)
                return;

            viewFileToolStripMenuItem.Enabled = true;

            if (Item.CanWrite == 1)
                FileProperitestoolStripMenuItem.Enabled = true;

            if (Item.CanDelete == 1)
                DeleteFiletoolStripMenuItem.Enabled = true;

            if (Category.UserLevelId == (int)nsLib.Utilities.Types.UserLevelType.Administrator)
                fileAdminLevelToolStripMenuItem.Enabled = true;

        }
        private void viewFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewFile();
        }
        private void addFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addFile();
        }
        private void DeleteFiletoolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteFile();
        }
        private void FileProperitestoolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileProperites();
        }
        private void filePermissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filePermission();
        }
        private void fileHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileHistory();
        }
        #endregion

        private void ItemBrowserFrm_Load(object sender, EventArgs e)
        {
            LoadIconsFromDB();
            CategoryDataBinding();

            
        }
        private void tlCategory_GetStateImage(object sender, DevExpress.XtraTreeList.GetStateImageEventArgs e)
        {
            if (dsQueries.QryCategory[e.Node.Id].IsIconIdNull() || dsQueries.QryCategory[e.Node.Id].IconId == 0)
                e.NodeImageIndex = 0;
            else
                e.NodeImageIndex = (int)sharedImageCollectionCategory.ImageSource.Images[dsQueries.QryCategory[e.Node.Id].IconId.ToString()].Tag;
        }
        private void gridViewFiles_CalcPreviewText(object sender, DevExpress.XtraGrid.Views.Grid.CalcPreviewTextEventArgs e)
        {
            if (e.Row == null)
                return;
            DataSources.dsQueries.QryItemsRow item = (DataSources.dsQueries.QryItemsRow)((DataRowView)e.Row).Row;
            if (item.IsInfoNull())
                e.PreviewText = string.Empty;
            else
                e.PreviewText = item.Info;
        }
        private void tlCategory_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (e.Node == null || e.Node.Id < 0)
                return;
            ItemDataBinding(e.Node.Id);
        }
        private void gridControlFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (GetGridDropFileName(e) == string.Empty)
                e.Effect = DragDropEffects.None;
            else
                e.Effect = DragDropEffects.Copy;
        }
        string GetGridDropFileName(DragEventArgs drag)
        {
            Array data = ((IDataObject)drag.Data).GetData("FileName") as Array;
            if (data == null || tlCategory.FocusedNode == null)
                return string.Empty;
            DataSources.dsQueries.QryCategoryRow Category = dsQueries.QryCategory[tlCategory.FocusedNode.Id];
            if (Category.CanInsert == 1)
                return data.GetValue(0).ToString();
            else
                return string.Empty;
        }
        private void gridControlFiles_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            string filePath = GetGridDropFileName(e);
            if (filePath == string.Empty)
                return;
            addFile(filePath);
        }
        private void gridControlFiles_MouseDown(object sender, MouseEventArgs e)
        {
            hitInfoItem = gridViewFiles.CalcHitInfo(new Point(e.X, e.Y));
        }
        private void gridControlFiles_MouseMove(object sender, MouseEventArgs e)
        {
            if (hitInfoItem == null) return;
            if (e.Button != MouseButtons.Left) return;
            Rectangle dragRect = new Rectangle(new Point(
                hitInfoItem.HitPoint.X - SystemInformation.DragSize.Width / 2,
                hitInfoItem.HitPoint.Y - SystemInformation.DragSize.Height / 2), SystemInformation.DragSize);
            if (!dragRect.Contains(new Point(e.X, e.Y)))
            {
                if (hitInfoItem.RowHandle < 0)
                    return;
                DataSources.dsQueries.QryItemsRow data = (DataSources.dsQueries.QryItemsRow)((DataRowView)gridViewFiles.GetRow(hitInfoItem.RowHandle)).Row;
                gridControlFiles.DoDragDrop(data, DragDropEffects.Move);
            }
        }
        private void tlCategory_MouseDown(object sender, MouseEventArgs e)
        {
            hitInfoCategory = tlCategory.CalcHitInfo(new Point(e.X, e.Y));
        }
        private void tlCategory_MouseMove(object sender, MouseEventArgs e)
        {
            if (hitInfoCategory == null || hitInfoCategory.Node == null) return;
            if (e.Button != MouseButtons.Left) return;
            Rectangle dragRect = new Rectangle(new Point(hitInfoCategory.MousePoint.X - SystemInformation.DragSize.Width / 2,
                hitInfoCategory.MousePoint.Y - SystemInformation.DragSize.Height / 2), SystemInformation.DragSize);
            if (!dragRect.Contains(new Point(e.X, e.Y)))
            {
                DataSources.dsQueries.QryCategoryRow data = (DataSources.dsQueries.QryCategoryRow)dsQueries.QryCategory[hitInfoCategory.Node.Id];
                tlCategory.DoDragDrop(data, DragDropEffects.Move);
            }
        }
        private void tlCategory_DragEnter(object sender, DragEventArgs e)
        {
            DataSources.dsQueries.QryItemsRow dataRowItem = (DataSources.dsQueries.QryItemsRow)e.Data.GetData(typeof(DataSources.dsQueries.QryItemsRow));
            DataSources.dsQueries.QryCategoryRow dataRowCategory = (DataSources.dsQueries.QryCategoryRow)e.Data.GetData(typeof(DataSources.dsQueries.QryCategoryRow));
            if (dataRowItem == null && dataRowCategory == null)
                return;
            e.Effect = DragDropEffects.Move;
        }
        private void tlCategory_DragDrop(object sender, DragEventArgs e)
        {
            DataSources.dsQueries.QryItemsRow dataRowItem = (DataSources.dsQueries.QryItemsRow)e.Data.GetData(typeof(DataSources.dsQueries.QryItemsRow));
            DataSources.dsQueries.QryCategoryRow dataRowCategory = (DataSources.dsQueries.QryCategoryRow)e.Data.GetData(typeof(DataSources.dsQueries.QryCategoryRow));

            TreeListHitInfo NodeDrop = tlCategory.CalcHitInfo(tlCategory.PointToClient(new Point(e.X, e.Y)));
            if (NodeDrop == null || NodeDrop.Node == null) return;
            if (dataRowItem != null)
            {
                string msg = string.Format("هل ترغب في نقل الملف للمجلد '{0}' ؟", NodeDrop.Node.GetDisplayText(colCategoryName1));
                if (MessageBox.Show(msg, "تغير مكان ملف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                    return;
                moveFile(dataRowItem, dsQueries.QryCategory[NodeDrop.Node.Id].CategoryId);
            }
            else if (dataRowCategory != null)
            {
                if (dataRowCategory.CategoryId == dsQueries.QryCategory[NodeDrop.Node.Id].CategoryId)//Drop to it self
                {
                    DataCenterX.LogMessage("لا يمكن نقل مجلد لنفسه", typeof(ItemBrowserFrm), nsLib.Utilities.Types.MessageType.Error, null, true);
                    return;
                }
                if (dataRowCategory.ParentID == dsQueries.QryCategory[NodeDrop.Node.Id].CategoryId)//Drop to its parent(same position)
                {
                    DataCenterX.LogMessage("لا يمكن نقل مجلد لنفس مكانة", typeof(ItemBrowserFrm), nsLib.Utilities.Types.MessageType.Error, null, true);
                    return;
                }
                if (NodeDrop.Node.HasAsParent(hitInfoCategory.Node))//Drop node is child Parent
                {
                    DataCenterX.LogMessage("لا يمكن نقل مجلد لاحد مجلداتة الفرعية", typeof(ItemBrowserFrm), nsLib.Utilities.Types.MessageType.Error, null, true);
                    return;
                }
                
                string msg = string.Format("هل ترغب في نقل المجلد {0} للمجلد '{1}' ؟", dataRowCategory.CategoryName, NodeDrop.Node.GetDisplayText(colCategoryName1));
                if (MessageBox.Show(msg, "تغير مكان مجلد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                    return;
                moveCategory(dataRowCategory.CategoryId, dataRowCategory.ParentID, dsQueries.QryCategory[NodeDrop.Node.Id].CategoryId);
            }
            
        }
        #endregion

    }
}
