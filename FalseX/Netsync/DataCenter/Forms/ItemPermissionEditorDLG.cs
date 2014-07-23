using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DataCenter.Managers;

namespace DataCenter.Forms
{
    public partial class ItemPermissionEditorDLG : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataSources.dsDataCenter.ItemRow _row;
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(CategoryPermissionEditorDLG));
        DataSources.Linq.dsDataCenterLinqDataContext linqDS = new DataSources.Linq.dsDataCenterLinqDataContext();
        #endregion
        #region -   Functions   -
        public ItemPermissionEditorDLG(DataSources.dsDataCenter.ItemRow row)
        {
            InitializeComponent();
            _row = row;
        }
        private void BindingsCollection()
        {
            // TODO: This line of code loads data into the 'dsDataCenter.UserLevel' table. You can move, or remove it, as needed.
            this.userLevelTableAdapter.Fill(this.dsDataCenter.UserLevel);

            // TODO: This line of code loads data into the 'dsDataCenter.CategoryUser' table. You can move, or remove it, as needed.
            this.categoryUserTableAdapter.FillByCategoryId(this.dsDataCenter.CategoryUser, _row.CategoryId);
            // TODO: This line of code loads data into the 'dsDataCenter.CategoryRole' table. You can move, or remove it, as needed.
            this.categoryRoleTableAdapter.FillByCategoryId(this.dsDataCenter.CategoryRole, _row.CategoryId);

            // TODO: This line of code loads data into the 'dsDataCenter.ItemRole' table. You can move, or remove it, as needed.
            this.itemRoleTableAdapter.FillByItemId(this.dsDataCenter.ItemRole, _row.ItemId);
            // TODO: This line of code loads data into the 'dsDataCenter.ItemUser' table. You can move, or remove it, as needed.
            this.itemUserTableAdapter.FillByItemId(this.dsDataCenter.ItemUser, _row.ItemId);
            
            lSMSCategory.QueryableSource = linqDS.vCategories;
            lSMSUser.QueryableSource = linqDS.vUsers;
            lSMSRole.QueryableSource = linqDS.vRoles;
            lSMSGrant.QueryableSource = linqDS.vGrants;
        }
        #endregion
        #region - Event Handlers -
        private void FilePermissionEditorDLG_Load(object sender, EventArgs e)
        {
            BindingsCollection();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void gridViewUser_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView GV = (GridView)gridControlUser.MainView;
            DataSources.dsDataCenter.ItemUserRow row = (DataSources.dsDataCenter.ItemUserRow)GV.GetDataRow(e.RowHandle);
            row.ItemId = _row.ItemId;
            row.CanRead = false; row.CanWrite = false; row.CanDelete = false;
            row.CanInsert = false; row.GrantId = (int)nsLib.Utilities.Types.GrantType.allow;

        }
        private void gridViewUser_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            if (e.ErrorText.Contains("UserID"))
            {
                //e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
                e.ErrorText = "من فضلك بجب اختيار اسم المستخدم";
                return;
            }
        }
        private void repositoryItemButtonEditUserSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlUser.MainView;
            DataSources.dsDataCenter.ItemUserRow row = (DataSources.dsDataCenter.ItemUserRow)GV.GetFocusedDataRow();

            try
            {
                itemUserBindingSource.EndEdit();

                nsLib.Utilities.Types.LogOpType LogOpType;
                if (row.RowState == DataRowState.Added)
                {
                    if (row.GrantId == (int)nsLib.Utilities.Types.GrantType.allow)
                        LogOpType = nsLib.Utilities.Types.LogOpType.AddAllowedUser;
                    else
                        LogOpType = nsLib.Utilities.Types.LogOpType.AddDeniedUser;
                }
                else
                {
                    if (row.GrantId == (int)nsLib.Utilities.Types.GrantType.allow)
                        LogOpType = nsLib.Utilities.Types.LogOpType.EditAllowedUser;
                    else
                        LogOpType = nsLib.Utilities.Types.LogOpType.EditDeniedUser;
                }
                AppManager.defaultInstance.LogOperation(nsLib.Utilities.Types.LogType.Item, row.ItemId, LogOpType, row.UserID);              
                
                itemUserTableAdapter.Update(row);
                dsDataCenter.ItemUser.AcceptChanges();
                DataCenterX.LogMessage(string.Format("تم حفظ صلاحيات المستخدمين للملف {0}", _row.ItemName), typeof(ItemPermissionEditorDLG), nsLib.Utilities.Types.MessageType.Success, null, true);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                DataCenterX.LogMessage("لم يتم حفظ صلاحيات المستخدمين", typeof(ItemPermissionEditorDLG), nsLib.Utilities.Types.MessageType.Error, ex, true);
            }
        }
        private void repositoryItemButtonEditUserDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            GridView GV = (GridView)gridControlUser.MainView;
            DataSources.dsDataCenter.ItemUserRow row = (DataSources.dsDataCenter.ItemUserRow)GV.GetFocusedDataRow();
            if (row.RowState == DataRowState.Detached)
                return;
            try
            {
                itemUserTableAdapter.Delete(row.ItemId, row.UserID);

                nsLib.Utilities.Types.LogOpType LogOpType;
                if (row.GrantId == (int)nsLib.Utilities.Types.GrantType.allow)
                    LogOpType = nsLib.Utilities.Types.LogOpType.DeleteAllowedUser;
                else
                    LogOpType = nsLib.Utilities.Types.LogOpType.DeleteDeniedUser;
                AppManager.defaultInstance.LogOperation(nsLib.Utilities.Types.LogType.Item, row.ItemId, LogOpType, row.UserID);
              
                gridViewUser.DeleteRow(GV.FocusedRowHandle);               
                DataCenterX.LogMessage("تم حذف صلاحية المستخدم", typeof(ItemPermissionEditorDLG), nsLib.Utilities.Types.MessageType.Success, null, true);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                DataCenterX.LogMessage("لم يتم حذف صلاحية المستخدم", typeof(ItemPermissionEditorDLG), nsLib.Utilities.Types.MessageType.Error, ex, true);
            }
        }

        private void gridViewRole_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView GV = (GridView)gridControlRole.MainView;
            DataSources.dsDataCenter.ItemRoleRow row = (DataSources.dsDataCenter.ItemRoleRow)GV.GetDataRow(e.RowHandle);

            row.ItemId = _row.ItemId;
            row.CanRead = false; row.CanWrite = false; row.CanDelete = false;
            row.CanInsert = false; row.GrantId = (int)nsLib.Utilities.Types.GrantType.allow;
        }
        private void gridViewRole_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            if (e.ErrorText.Contains("RoleID"))
            {
                //e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
                e.ErrorText = "من فضلك بجب اختيار مجموعة";
                return;
            }
        }
        private void repositoryItemButtonEditRoleSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlRole.MainView;
            DataSources.dsDataCenter.ItemRoleRow row = (DataSources.dsDataCenter.ItemRoleRow)GV.GetFocusedDataRow();
            
            try
            {
                itemRoleBindingSource.EndEdit();

                nsLib.Utilities.Types.LogOpType LogOpType;
                if (row.RowState == DataRowState.Added)
                {
                    if (row.GrantId == (int)nsLib.Utilities.Types.GrantType.allow)
                        LogOpType = nsLib.Utilities.Types.LogOpType.AddAllowedRole;
                    else
                        LogOpType = nsLib.Utilities.Types.LogOpType.AddDeniedRole;
                }
                else
                {
                    if (row.GrantId == (int)nsLib.Utilities.Types.GrantType.allow)
                        LogOpType = nsLib.Utilities.Types.LogOpType.EditAllowedRole;
                    else
                        LogOpType = nsLib.Utilities.Types.LogOpType.EditDeniedRole;
                }
                AppManager.defaultInstance.LogOperation(nsLib.Utilities.Types.LogType.Item, row.ItemId, LogOpType, row.RoleID);
               
                itemRoleTableAdapter.Update(row);
                dsDataCenter.ItemRole.AcceptChanges();
                DataCenterX.LogMessage(string.Format("تم حفظ صلاحيات المجموعات للملف {0}", _row.ItemName), typeof(ItemPermissionEditorDLG), nsLib.Utilities.Types.MessageType.Success, null, true);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                DataCenterX.LogMessage("لم يتم حفظ صلاحيات المجموعات", typeof(ItemPermissionEditorDLG), nsLib.Utilities.Types.MessageType.Error, ex, true);
            }
        }
        private void repositoryItemButtonEditRoleDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            GridView GV = (GridView)gridControlRole.MainView;
            DataSources.dsDataCenter.ItemRoleRow row = (DataSources.dsDataCenter.ItemRoleRow)GV.GetFocusedDataRow();
            if (row.RowState == DataRowState.Detached)
                return;
            try
            {
                itemRoleTableAdapter.Delete(row.ItemId, row.RoleID);

                nsLib.Utilities.Types.LogOpType LogOpType;
                if (row.GrantId == (int)nsLib.Utilities.Types.GrantType.allow)
                    LogOpType = nsLib.Utilities.Types.LogOpType.DeleteAllowedRole;
                else
                    LogOpType = nsLib.Utilities.Types.LogOpType.DeleteDeniedRole;
                AppManager.defaultInstance.LogOperation(nsLib.Utilities.Types.LogType.Item, row.ItemId, LogOpType, row.RoleID);
                
                gridViewRole.DeleteRow(GV.FocusedRowHandle);
                DataCenterX.LogMessage("تم حذف صلاحية المجموعة", typeof(ItemPermissionEditorDLG), nsLib.Utilities.Types.MessageType.Success, null, true);

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                DataCenterX.LogMessage("لم يتم حذف صلاحيات المجموعات", typeof(ItemPermissionEditorDLG), nsLib.Utilities.Types.MessageType.Error, ex, true);
            }
        }
        #endregion

    }
}
