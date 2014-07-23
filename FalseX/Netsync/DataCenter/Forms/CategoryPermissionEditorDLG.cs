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
    public partial class CategoryPermissionEditorDLG : DevExpress.XtraEditors.XtraForm
    {

        #region -   Variables   -
        DataSources.dsDataCenter.CategoryRow _row;
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(CategoryPermissionEditorDLG));
        DataSources.Linq.dsDataCenterLinqDataContext linqDS = new DataSources.Linq.dsDataCenterLinqDataContext();
        #endregion
        #region -   Functions   -
        public CategoryPermissionEditorDLG(DataSources.dsDataCenter.CategoryRow row)
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

            lSMSCategory.QueryableSource = linqDS.vCategories;
            lSMSUser.QueryableSource = linqDS.vUsers;
            lSMSRole.QueryableSource = linqDS.vRoles;
            lSMSGrant.QueryableSource = linqDS.vGrants;
        }
        #endregion
        #region - Event Handlers -
        private void CategoryEditorDLG_Load(object sender, EventArgs e)
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
            DataSources.dsDataCenter.CategoryUserRow row = (DataSources.dsDataCenter.CategoryUserRow)GV.GetDataRow(e.RowHandle);
            row.CategoryId = _row.CategoryId;
            row.UserLevelId = (int)nsLib.Utilities.Types.UserLevelType.User;
            row.CanRead = false; row.CanWrite = false; row.CanDelete = false;
            row.CanInsert = false; row.Inheritance = false; row.GrantId = 1;

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
        private void gridViewUser_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView GV = sender as GridView;
            if (GV.FocusedColumn.FieldName == "Inheritance")
            {
                DataSources.dsDataCenter.CategoryUserRow row = (DataSources.dsDataCenter.CategoryUserRow)GV.GetFocusedDataRow();
                if (row.Inheritance && row.CategoryId != row.InheritanceCategoryId && row.RowState != DataRowState.Detached)
                    e.Cancel = true;
            }
        }
        private void repositoryItemButtonEditUserSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlUser.MainView;
            DataSources.dsDataCenter.CategoryUserRow row = (DataSources.dsDataCenter.CategoryUserRow)GV.GetFocusedDataRow();
            
            bool? Inheritance = row.Inheritance;
            bool InheritanceChanged = false;
            categoryUserBindingSource.EndEdit();
            try
            {
                if (Inheritance != null)
                {
                    if (row.RowState == DataRowState.Detached || row.RowState == DataRowState.Added)
                        InheritanceChanged = true;
                    else if ((bool)row["Inheritance", DataRowVersion.Original] != (bool)row["Inheritance", DataRowVersion.Current])
                        InheritanceChanged = true;
                    if (Inheritance == true && InheritanceChanged)
                        row.InheritanceCategoryId = _row.CategoryId;
                    else if(Inheritance == false && InheritanceChanged)
                        row.SetInheritanceCategoryIdNull();
                }
              
                categoryUserBindingSource.EndEdit();

                AppManager.defaultInstance.LogOperation(nsLib.Utilities.Types.LogType.Categoy, row.CategoryId, GetLogOpType4Role(row, false), row.UserID);
                categoryUserTableAdapter.Update(row);
                dsDataCenter.CategoryUser.AcceptChanges();
                DataCenterX.LogMessage(string.Format("تم حفظ صلاحيات المستخدمين للمجلد {0}", _row.CategoryName), typeof(CategoryPermissionEditorDLG), nsLib.Utilities.Types.MessageType.Success, null, true);
                if (InheritanceChanged)
                {
                    if (!DataManager.defaultInstance.UpdateSubCategoryInheritancePrivilages(row, false))
                    {
                        DataCenterX.LogMessage("لم يتم حفظ صلاحيات المجلد", typeof(CategoryPermissionEditorDLG), nsLib.Utilities.Types.MessageType.Error, null, true);
                        return;
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                DataCenterX.LogMessage("لم يتم حفظ المجلد", typeof(CategoryPermissionEditorDLG), nsLib.Utilities.Types.MessageType.Error, ex, true);
            }
        }
        private void repositoryItemButtonEditUserDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            GridView GV = (GridView)gridControlUser.MainView;
            DataSources.dsDataCenter.CategoryUserRow row = (DataSources.dsDataCenter.CategoryUserRow)GV.GetFocusedDataRow();
            if (row.RowState == DataRowState.Detached)
                return;
            bool? Inheritance = row.Inheritance;
            categoryUserBindingSource.EndEdit();
            try
            {
                if (Inheritance != null && Inheritance == true && row.InheritanceCategoryId != _row.CategoryId)
                {
                    DataCenterX.LogMessage("لا يمكن حذف صلاحية مشتركة من هنا. يجب حذفها من المجلد الرئيسي", typeof(CategoryPermissionEditorDLG), 
                        nsLib.Utilities.Types.MessageType.Error, null, true);
                    return;
                }
                //Update Inheritance User
                if (Inheritance != null && Inheritance == true)
                {
                    if (!DataManager.defaultInstance.UpdateSubCategoryInheritancePrivilages(row, true))
                    {
                        DataCenterX.LogMessage("لم يتم حفظ صلاحيات المجلد", typeof(CategoryPermissionEditorDLG), nsLib.Utilities.Types.MessageType.Error, null, true);
                        return;
                    }
                }

                categoryUserTableAdapter.Delete(row.UserID, row.CategoryId, row.GrantId);
                AppManager.defaultInstance.LogOperation(nsLib.Utilities.Types.LogType.Categoy, row.CategoryId, GetLogOpType4Role(row, true), row.UserID);
                
                gridViewUser.DeleteRow(GV.FocusedRowHandle);
                DataCenterX.LogMessage("تم حذف صلاحية المستخدم", typeof(CategoryPermissionEditorDLG), nsLib.Utilities.Types.MessageType.Success, null, true);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                DataCenterX.LogMessage("لم يتم حذف صلاحية المستخدم", typeof(CategoryPermissionEditorDLG), nsLib.Utilities.Types.MessageType.Error, ex, true);
            }
        }
        private static nsLib.Utilities.Types.LogOpType GetLogOpType4Role(DataSources.dsDataCenter.CategoryUserRow row, bool Delete)
        {
            nsLib.Utilities.Types.LogOpType LogOpType;

            if (Delete)
            {
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
            }
            else
            {
                if (row.GrantId == (int)nsLib.Utilities.Types.GrantType.allow)
                    LogOpType = nsLib.Utilities.Types.LogOpType.DeleteAllowedUser;
                else
                    LogOpType = nsLib.Utilities.Types.LogOpType.DeleteDeniedUser;
            }
            return LogOpType;
        }

        private void gridViewRole_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView GV = (GridView)gridControlRole.MainView;
            DataSources.dsDataCenter.CategoryRoleRow row = (DataSources.dsDataCenter.CategoryRoleRow)GV.GetDataRow(e.RowHandle);

            row.CategoryId = _row.CategoryId;
            row.UserLevelId = (int)nsLib.Utilities.Types.UserLevelType.User;
            row.CanRead = false; row.CanWrite = false; row.CanDelete = false;
            row.CanInsert = false; row.Inheritance = false; row.GrantId = 1;
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
        private void gridViewRole_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView GV = sender as GridView;
            if (GV.FocusedColumn.FieldName == "Inheritance")
            {
                DataSources.dsDataCenter.CategoryRoleRow row = (DataSources.dsDataCenter.CategoryRoleRow)GV.GetFocusedDataRow();
                if (row.Inheritance && row.CategoryId != row.InheritanceCategoryId && row.RowState != DataRowState.Detached)
                    e.Cancel = true;
            }
        }        
        private void repositoryItemButtonEditRoleSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlRole.MainView;
            DataSources.dsDataCenter.CategoryRoleRow row = (DataSources.dsDataCenter.CategoryRoleRow)GV.GetFocusedDataRow();
            bool? Inheritance = row.Inheritance;
            bool InheritanceChanged = false;
            categoryRoleBindingSource.EndEdit();
       
            if (row.RowState == DataRowState.Unchanged)
                return;
            try
            {
                if (Inheritance != null)
                {
                    //if (row.RowState != DataRowState.Detached)
                    //{
                    //    MessageBox.Show(string.Format("Org:{0}{1}Curr:{2}{3}Proposed:{4}{5}Def:{6}", row["Inheritance", DataRowVersion.Original], Environment.NewLine,
                    //        row["Inheritance", DataRowVersion.Current], Environment.NewLine, row["Inheritance", DataRowVersion.Default], Environment.NewLine,
                    //        row["Inheritance", DataRowVersion.Default]));
                    //}
                    if (row.RowState == DataRowState.Detached || row.RowState == DataRowState.Added)
                        InheritanceChanged = true;
                    else if ((bool)row["Inheritance", DataRowVersion.Original] != (bool)row["Inheritance", DataRowVersion.Current])
                        InheritanceChanged = true;
                    if (Inheritance == true && InheritanceChanged)
                        row.InheritanceCategoryId = _row.CategoryId;
                    else if (Inheritance == false && InheritanceChanged)
                        row.SetInheritanceCategoryIdNull();
                }

                categoryRoleBindingSource.EndEdit();
                AppManager.defaultInstance.LogOperation(nsLib.Utilities.Types.LogType.Categoy, row.CategoryId, GetLogOpType4User(row, false), row.RoleID);
                categoryRoleTableAdapter.Update(row);
                dsDataCenter.CategoryRole.AcceptChanges();
                DataCenterX.LogMessage(string.Format("تم حفظ صلاحيات المجموعات للمجلد {0}", _row.CategoryName), typeof(CategoryPermissionEditorDLG), nsLib.Utilities.Types.MessageType.Success, null, true);
                if (InheritanceChanged)
                {
                    if (!DataManager.defaultInstance.UpdateSubCategoryInheritancePrivilages(row, false))
                    {
                        DataCenterX.LogMessage("لم يتم حفظ صلاحيات المجلد", typeof(CategoryPermissionEditorDLG), nsLib.Utilities.Types.MessageType.Error, null, true);
                        return;
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                DataCenterX.LogMessage("لم يتم حذف صلاحية المجموعة", typeof(CategoryPermissionEditorDLG), nsLib.Utilities.Types.MessageType.Error, ex, true);
            }
        }
        private void repositoryItemButtonEditRoleDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            GridView GV = (GridView)gridControlRole.MainView;
            DataSources.dsDataCenter.CategoryRoleRow row = (DataSources.dsDataCenter.CategoryRoleRow)GV.GetFocusedDataRow();
            if (row.RowState == DataRowState.Detached)
                return;
            bool? Inheritance = row.Inheritance;
            categoryRoleBindingSource.EndEdit();
            try
            {
                if (Inheritance != null && Inheritance == true && row.InheritanceCategoryId != _row.CategoryId)
                {
                    DataCenterX.LogMessage("لا يمكن حذف صلاحية مشتركة من هنا. يجب حذفها من المجلد الرئيسي", typeof(CategoryPermissionEditorDLG),
                        nsLib.Utilities.Types.MessageType.Error, null, true);
                    return;
                }

                //Update Inheritance Role
                if (Inheritance != null && Inheritance == true)
                {
                    if (!DataManager.defaultInstance.UpdateSubCategoryInheritancePrivilages(row, true))
                    {
                        DataCenterX.LogMessage("تم حذف صلاحية المجموعة", typeof(CategoryPermissionEditorDLG), nsLib.Utilities.Types.MessageType.Success, null, true);
                        return;
                    }
                }

                categoryRoleTableAdapter.Delete(row.CategoryId, row.RoleID, row.GrantId);
                AppManager.defaultInstance.LogOperation(nsLib.Utilities.Types.LogType.Categoy, row.CategoryId, GetLogOpType4User(row, true), row.RoleID);
              
                gridViewRole.DeleteRow(GV.FocusedRowHandle);
                DataCenterX.LogMessage("تم حذف صلاحية المجموعة", typeof(CategoryPermissionEditorDLG), nsLib.Utilities.Types.MessageType.Success, null, true);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                DataCenterX.LogMessage("لم يتم حذف صلاحية المجموعة", typeof(CategoryPermissionEditorDLG), nsLib.Utilities.Types.MessageType.Error, ex, true);
            }
        }
        private static nsLib.Utilities.Types.LogOpType GetLogOpType4User(DataSources.dsDataCenter.CategoryRoleRow row, bool Delete)
        {
            nsLib.Utilities.Types.LogOpType LogOpType;
            if (Delete)
            {
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
            }
            else
            {
                if (row.GrantId == (int)nsLib.Utilities.Types.GrantType.allow)
                    LogOpType = nsLib.Utilities.Types.LogOpType.DeleteAllowedRole;
                else
                    LogOpType = nsLib.Utilities.Types.LogOpType.DeleteDeniedRole;
            }

            return LogOpType;
        }
        
        #endregion

    }
}
