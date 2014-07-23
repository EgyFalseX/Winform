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

namespace DataCenter.Forms
{
    public partial class UserRoleFrm : DevExpress.XtraEditors.XtraForm
    {

        public UserRoleFrm()
        {
            InitializeComponent();
        }
        void LoadDefaultData()
        {
            // TODO: This line of code loads data into the 'dsDataCenter.Roles' table. You can move, or remove it, as needed.
            this.rolesTableAdapter.Fill(this.dsDataCenter.Roles);
            // TODO: This line of code loads data into the 'dsDataCenter.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dsDataCenter.Users);
        }
        void LoadData()
        {
            // TODO: This line of code loads data into the 'dsDataCenter.UserRole' table. You can move, or remove it, as needed.
            this.userRoleTableAdapter.FillByUserId(this.dsDataCenter.UserRole, Convert.ToInt32(lueUserId.EditValue));
        }
        private void FileTypeFrm_Load(object sender, EventArgs e)
        {
            LoadDefaultData();
        }
        private void lueUserId_EditValueChanged(object sender, EventArgs e)
        {
            if (lueUserId.EditValue == null || lueUserId.EditValue.ToString() == string.Empty)
            {
                return;
            }
            LoadData();
            gridControlData.Enabled = true;
        }
        private void gridViewData_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            DataRowView DRV = (DataRowView)e.Row;
            if (e.ErrorText.Contains("id"))
            {
                e.ErrorText = "";
                return;
            }
        }
        private void gridViewData_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            if (lueUserId.EditValue == null || lueUserId.EditValue.ToString() == string.Empty)
            {
                gridViewData.DeleteRow(e.RowHandle);
                return;
            }
            DataSources.dsDataCenter.UserRoleRow row = (DataSources.dsDataCenter.UserRoleRow)gridViewData.GetDataRow(e.RowHandle);
            row.UserId = Convert.ToInt32(lueUserId.EditValue);
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsDataCenter.UserRoleRow row = (DataSources.dsDataCenter.UserRoleRow)GV.GetFocusedDataRow();
            try
            {
                userRoleBindingSource.EndEdit();
                userRoleTableAdapter.Update(row);
                dsDataCenter.UserRole.AcceptChanges();
                DataCenterX.LogMessage("تم تعديل مجموعات المستخدم", typeof(UserRoleFrm), nsLib.Utilities.Types.MessageType.Success, null, true);
                LoadData();
            }
            catch (SqlException ex)
            {
                DataCenterX.LogMessage("لم يتم تعديل مجموعات المستخدم", typeof(UserRoleFrm), nsLib.Utilities.Types.MessageType.Error, ex, true);
            }
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsDataCenter.UserRoleRow row = (DataSources.dsDataCenter.UserRoleRow)GV.GetFocusedDataRow();
            try
            {
                userRoleTableAdapter.Delete(row.UserId, row.RoleId);
                gridViewData.DeleteRow(gridViewData.FocusedRowHandle);
                LoadData();
                DataCenterX.LogMessage("تم حذف المجموعة", typeof(UserRoleFrm), nsLib.Utilities.Types.MessageType.Success, null, true);
            }
            catch (SqlException ex)
            {
                DataCenterX.LogMessage("لم يتم حذف المجموعة", typeof(UserRoleFrm), nsLib.Utilities.Types.MessageType.Error, ex, true);

            }
        }

        
        
    }
}
